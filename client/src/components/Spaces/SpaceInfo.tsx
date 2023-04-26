import { useMutation, useQuery } from "@apollo/client";
import { Box, Button, Modal } from "@mui/material";
import { DataGrid, GridRowParams, MuiEvent } from '@mui/x-data-grid';
import { Field, Form, Formik } from "formik";
import { useContext, useEffect, useState } from "react";
import { Outlet, useNavigate, useParams } from "react-router-dom";
import { CMSContext, CMSContextType } from "../../CMSContext";
import { createElModalStyle } from "../../common/styles";
import { ContentTypeDto, CreateContentTypePayload, MutationCreateContentTypeArgs } from "../../generated-gql/graphql";
import { getEntityUrl } from "../common/helpers";
import { NEW_CONTENT_TYPE } from "../Content/mutation";
import { QUERY_ENTITES } from "../Content/query";
import { StyledField } from "../Content/styles";
import { columns } from "./tableConfig";

const SpaceInfo = () => {
    const navigate = useNavigate();
    const { spaceId, entityId } = useParams();

    const {
        setSpaceId,
        organizationId,
        refreshEntitiesList,
        setRefreshEntitiesList }
        = useContext(CMSContext) as CMSContextType;

    const { data, error, loading, refetch } = useQuery(
        QUERY_ENTITES, {
        variables: {
            spaceId
        },
        onCompleted: () => setRefreshEntitiesList(false)
    });

    useEffect(() => {
        if (spaceId) {
            setSpaceId(spaceId);
        }
    }, [spaceId])


    useEffect(() => {
        if (refreshEntitiesList) {
            console.log('refetching ');
            refetch();
        }
    }, [refreshEntitiesList])

    const [mutationFunction, ...mutationResult]
        = useMutation<CreateContentTypePayload, MutationCreateContentTypeArgs>(
            NEW_CONTENT_TYPE, {
            errorPolicy: "all",
            onCompleted: (data: any) => {
                const entityId = data?.createContentType?.id;
                if (!entityId) {
                    console.error("no id provided when creating the entity");
                }
                handleClose();
                const redirectTo = getEntityUrl(organizationId, spaceId!, entityId);
                setRefreshEntitiesList(true);
                navigate(redirectTo);
            }
        }
        );

    // TODO: delete content types. For nested, detach them first.

    const tableView =
        loading ?
            <p>loading ...</p> :
            (data ? <div style={{
                minHeight: 500,
                height: '50vh',
                width: '100%'
            }}>
                <DataGrid
                    style={{ cursor: 'pointer' }}
                    rowSelection={false}
                    onRowClick={(params: GridRowParams<ContentTypeDto>, e: MuiEvent) => {
                        e.defaultMuiPrevented = true;
                        navigate(`entity/${params.row.id}`)
                        return;
                    }}
                    rows={data.entitiesBySpace}
                    columns={columns}
                    pageSizeOptions={[100]}
                />
            </div> : <p>no data</p>);

    const [open, setOpen] = useState(false)
    const handleClose = () => {
        setOpen(false);
    }
    const handleOpen = () => {
        setOpen(true);
    }

    const initialValues = {
        name: "",
        description: ""
    }


    return (
        <div>
            <Button
                onClick={handleOpen}
                variant="contained"
                style={{ marginBottom: '10px' }}
                size='small'>
                New Content Type
            </Button>
            {!entityId && tableView}
            <Outlet />
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="create new content type"
                aria-describedby="create new content type"
            >
                <Box sx={{
                    ...createElModalStyle,
                    width: 400
                }}
                    rowGap={3}
                    columnGap={3}>
                    <h2 id="parent-modal-title">Create Content Type</h2>
                    {loading ? '...' :
                        <Formik
                            initialValues={initialValues}
                            onSubmit={(fields) => {
                                mutationFunction({
                                    variables: {
                                        input: {
                                            uniqueName: fields.name,
                                            description: fields.description,
                                            spaceId
                                        }
                                    }
                                });
                                console.log(fields, spaceId, organizationId)
                            }}
                        >
                            {({ values, submitForm }) => (
                                <Form style={{ display: 'flex', flexDirection: 'column' }}>
                                    <label htmlFor='name'>Unique Name</label>
                                    <StyledField
                                        id="name"
                                        name="name"
                                        label="unique name"
                                        palceholder="Name identifier" />
                                    <label htmlFor='description'>Description</label>
                                    <Field
                                        id='description'
                                        as='textarea'
                                        name="description"
                                        label="Description"
                                        style={{ height: '50px' }}
                                        palceholder={"Description"} />
                                    <Button
                                        style={{ marginTop: "20px" }}
                                        type='submit'
                                        variant='contained'>
                                        Create
                                    </Button>
                                </Form>
                            )}
                        </Formik>
                    }
                </Box>
            </Modal>
        </div>

    )
}

export default SpaceInfo;