import { useQuery } from "@apollo/client";
import AddBoxIcon from '@mui/icons-material/AddBox';
import DeleteForeverIcon from '@mui/icons-material/DeleteForever';
import { Button, Divider } from "@mui/material";
import Box from "@mui/material/Box";
import { FieldArray, Formik } from "formik";
import { Form, useParams } from "react-router-dom";
import { EntityByIdQuery } from "../../generated-gql/graphql";
import { EntityTreeView } from "./EntityTreeView";
import { QUERY_SINGLE_ENTITY } from "./query";
import { StyledField } from "./styles";

const EntityInfo = () => {
    const { entityId } = useParams();
    let { loading, error, data } = useQuery<EntityByIdQuery>(QUERY_SINGLE_ENTITY, {
        variables: { id: entityId },
    });

    const newBasicField = (): { name: string, value: string } => {
        return { value: "", name: "" }
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
                    {({ values, submitForm }) => (
                        <Form>
                            <FieldArray
                                name='basicFields'
                                render={({ insert, remove, push }) => {
                                    return <div>
                                        {values.basicFields && values.basicFields.length > 0 ? (
                                            values.basicFields.map((value, i) => (
                                                <div key={i}>
                                                    <StyledField
                                                        name={`basicFields[${i}].name`} />
                                                    <StyledField
                                                        name={`basicFields[${i}].value`} />
                                                    <Button
                                                        size='small'
                                                        type="button"
                                                        onClick={() => insert(i + 1, newBasicField())}
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
                                                onClick={() => push(newBasicField())}>
                                                {/* show this when user has deleted all fields */}
                                                Add new field
                                            </Button>
                                        )}
                                    </div>
                                }}
                            />
                            <Button
                                style={{ marginBottom: 20 }}
                                type="submit"
                                variant='contained'
                                size='small'
                                onClick={submitForm}>
                                Save
                            </Button>
                        </Form>
                    )}
                </Formik>}

            {data && <EntityTreeView data={data} />}
        </Box>
    )
}

export default EntityInfo;