import { useMutation, useQuery } from "@apollo/client";
import AddBoxIcon from '@mui/icons-material/AddBox';
import DeleteForeverIcon from '@mui/icons-material/DeleteForever';
import { Button, Divider } from "@mui/material";
import Box from "@mui/material/Box";
import { Field, FieldArray, Formik } from "formik";
import { cloneElement, useState } from "react";
import { Form, useParams } from "react-router-dom";
import { EMPTY_GUID, TYPE_NAMES } from "../../constants";
import { BasicFieldDto, Cms_Type, EntityByIdQuery, MutationUpdateContentFieldsArgs, UpdateContentFieldsPayload } from "../../generated-gql/graphql";
import { AddDynamicTypeModal } from "../common/AddTypeModal";
import { SetFieldValueCallback, TYPES_MAPPING } from "../common/ContentTypes";
import { isValidGuid, serializeField } from "../common/helpers";
import { EntityTreeView } from "./EntityTreeView";
import { UPDATE_CONTENT_FIELDS } from "./mutation";
import { QUERY_SINGLE_ENTITY } from "./query";
import { StyledField } from "./styles";

const EntityInfo = () => {
    const { entityId } = useParams();
    let { loading, error, data } = useQuery<EntityByIdQuery>(QUERY_SINGLE_ENTITY, {
        variables: { id: entityId },
    });

    const [mutationFunction] = useMutation<UpdateContentFieldsPayload,
        MutationUpdateContentFieldsArgs>(UPDATE_CONTENT_FIELDS, {
            onCompleted: (data: any) => {
                console.log("mutation completed ", data)
            }
        })

    const newBasicField = (type: number, value?: string, name?: string): { type: number, name?: string, value?: string } => {
        return { type, value, name }
    }

    const [open, setOpen] = useState(false)
    const [selectedType, setSelectedType] = useState(-1)
    const [atPosition, setAtPosition] = useState(0)
    const onOpenModal = (atPosition: number) => {
        setOpen(true);
        setAtPosition(atPosition);
    }

    const getField = (value: BasicFieldDto, index: number,
        setFieldValueCb?: SetFieldValueCallback) => {
        if (value?.type !== undefined) {
            const obj = TYPES_MAPPING[value.type!];
            if (obj && obj.component) {

                let propertyName = parseInt(value.type.toString()) === TYPE_NAMES.Array ?
                    `basicFields[${index}].listItems` : `basicFields[${index}].value`;

                const comp = obj.component(propertyName, value, setFieldValueCb);
                if (comp) {
                    const componentWithId = cloneElement(comp, { id: `value-${index}` });
                    return componentWithId;
                }
            }
        }
        return null
    }

    const handleSubmit = async (basicFields: BasicFieldDto[]) => {
        const serializedFields = await Promise.all(
            basicFields.map(async field => {
                return Object.assign({},
                    field,
                    {
                        id: isValidGuid(field.id) ? field.id : EMPTY_GUID,
                        value: await serializeField(field),
                        type: parseInt(field.type.toString()), // sometimes type comes as string, ensure to be a number
                        __typename: undefined,
                        listItems: field.listItems?.map(li => {
                            return Object.assign({}, li, { __typename: undefined });
                        })
                    })
            }));

        console.log(serializedFields)
        mutationFunction({
            variables: {
                input: {
                    entityId,
                    fields: serializedFields
                }
            }
        })
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
                    onSubmit={({ basicFields }) => handleSubmit(basicFields)}
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
                                                    <Box display='flex'
                                                        flexWrap={'wrap'} >
                                                        <div>
                                                            <label htmlFor={`name-${i}`}>
                                                                Unique name: &nbsp;
                                                            </label>
                                                            <StyledField
                                                                id={`name-${i}`}
                                                                name={`basicFields[${i}].name`} />
                                                        </div>
                                                        <div>
                                                            <label htmlFor={`value-${i}`}>
                                                                Value: &nbsp;
                                                            </label>
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
                                                        </div>
                                                    </Box>
                                                    <Divider style={{ marginBottom: 20 }} light />
                                                </div>
                                            ))
                                        ) : (
                                            <Button
                                                type="button"
                                                variant='outlined'
                                                size='medium'
                                                onClick={() => push(newBasicField(0))}>
                                                {/* show this when user has deleted all fields */}
                                                Add new field
                                            </Button>
                                        )}
                                        <AddDynamicTypeModal
                                            open={open}
                                            onClose={() => { setOpen(false) }}
                                            onAddInput={(selectedType: number) => {
                                                setSelectedType(selectedType)
                                                insert(atPosition + 1, newBasicField(selectedType));
                                                setOpen(false);
                                                setSelectedType(-1);
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
                    )
                    }
                </Formik >}

            {data && <EntityTreeView data={data} />}
        </Box >
    )
}

export default EntityInfo;