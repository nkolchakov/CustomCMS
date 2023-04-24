import { useQuery } from "@apollo/client";
import AddBoxIcon from '@mui/icons-material/AddBox';
import DeleteForeverIcon from '@mui/icons-material/DeleteForever';
import { Button, Divider } from "@mui/material";
import Box from "@mui/material/Box";
import { Field, FieldArray, Formik } from "formik";
import { useState } from "react";
import { Form, useParams } from "react-router-dom";
import { BasicFieldDto, EntityByIdQuery } from "../../generated-gql/graphql";
import { AddDynamicTypeModal } from "../common/AddTypeModal";
import { SetFieldValueCallback, TYPES_MAPPING } from "../common/ContentTypes";
import { EntityTreeView } from "./EntityTreeView";
import { QUERY_SINGLE_ENTITY } from "./query";
import { StyledField } from "./styles";

const EntityInfo = () => {
    const { entityId } = useParams();
    let { loading, error, data } = useQuery<EntityByIdQuery>(QUERY_SINGLE_ENTITY, {
        variables: { id: entityId },
    });

    const newBasicField = (type: string, value: string = "", name: string = ""): { type: string, name: string, value: string } => {
        return { type, value, name }
    }

    const [open, setOpen] = useState(false)
    const [selectedType, setSelectedType] = useState('')
    const [atPosition, setAtPosition] = useState(0)
    const onOpenModal = (atPosition: number) => {
        setOpen(true);
        setAtPosition(atPosition);
    }

    const getField = (value: Partial<BasicFieldDto> | undefined, index: number, setFieldValueCb?: SetFieldValueCallback) => {
        if (value?.type) {
            const obj = TYPES_MAPPING[value.type.toLowerCase()];
            if (obj && obj.component) {
                const comp = obj.component(`basicFields[${index}].value`, value.value, setFieldValueCb);
                return comp;
            }
        }
        return null
    }

    const handleSubmit = () => {

    }

    return (
        <Box
            overflow='hidden'
            display={'flex'}
            flexDirection='row'
            flexWrap={'wrap'}
            justifyContent={'space-between'}
            marginTop={'50px'}>
            {!loading && data &&
                <Formik
                    enableReinitialize={true}
                    initialValues={data?.entityById!}
                    onSubmit={({ basicFields }) => {
                        console.log(basicFields)
                    }}
                >
                    {({ values, submitForm, setFieldValue }) => (
                        <Form>
                            <FieldArray
                                name='basicFields'
                                render={({ insert, remove, push }) => {
                                    return <div>
                                        {values.basicFields && values.basicFields.length > 0 ? (
                                            values.basicFields.map((value, i) => (
                                                <div key={i}>
                                                    {JSON.stringify(value)}
                                                    <StyledField
                                                        name={`basicFields[${i}].name`} />
                                                    {/* <StyledField
                                                        name={`basicFields[${i}].value`} /> */}
                                                    {getField(value, i, setFieldValue)}
                                                    <Button
                                                        size='small'
                                                        type="button"
                                                        onClick={() => onOpenModal(i)}
                                                    >
                                                        <AddBoxIcon />
                                                    </Button>
                                                    <Button
                                                        size='small'
                                                        type="button"
                                                        color='secondary'
                                                        onClick={() => remove(i)}
                                                    >
                                                        <DeleteForeverIcon />
                                                    </Button>
                                                    <Divider style={{ marginBottom: 20 }} light />
                                                </div>
                                            ))
                                        ) : (
                                            <Button
                                                type="button"
                                                variant='outlined'
                                                size='medium'
                                                onClick={() => push(newBasicField("text"))}>
                                                {/* show this when user has deleted all fields */}
                                                Add new field
                                            </Button>
                                        )}
                                        <AddDynamicTypeModal
                                            open={open}
                                            onClose={() => { setOpen(false) }}
                                            onAddInput={(selectedType: string) => {
                                                setSelectedType(selectedType)
                                                insert(atPosition + 1, newBasicField(selectedType));
                                                setOpen(false);
                                                setSelectedType("");
                                            }}
                                            onSubmit={(values: any) => console.log(values)}
                                            isLoading={loading}
                                        />
                                    </div>
                                }}
                            />
                            <Button
                                style={{ marginBottom: 20 }}
                                type="submit"
                                variant='contained'
                                size='small'
                                onClick={(event: any) => {
                                    event.preventDefault();
                                    event.stopPropagation();
                                    console.log("form submit")
                                    submitForm()
                                }}>
                                Save
                            </Button>
                        </Form>
                    )}
                </Formik>}

            {data && <EntityTreeView data={data} />}
        </Box >
    )
}

export default EntityInfo;