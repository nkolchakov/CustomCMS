import { useQuery } from "@apollo/client";
import { Box, Button, Modal } from "@mui/material";
import { style } from "@mui/system";
import { DataGrid, GridRowParams, MuiEvent } from '@mui/x-data-grid';
import { Field, Formik } from "formik";
import { useState } from "react";
import { Form, Outlet, useNavigate, useParams } from "react-router-dom";
import { createElModalStyle } from "../../common/styles";
import { TYPE_NAMES } from "../../constants";
import { ContentTypeDto } from "../../generated-gql/graphql";
import { ContentTypeField, TYPES_MAPPING } from "../common/ContentTypes";
import { QUERY_ENTITES } from "../Content/query";
import { columns } from "./tableConfig";

const SpaceInfo = () => {
    const navigate = useNavigate();
    const { spaceId, entityId } = useParams();
    const { data, error, loading } = useQuery(
        QUERY_ENTITES, {
        variables: {
            spaceId
        }
    })

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

    const onTypeChange = (e: any) => {
        const typeKey = e.target.value;
        console.log(typeKey);
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
                            initialValues={data?.entityById!}
                            onSubmit={({ basicFields }) => {
                                console.log(basicFields)
                            }}
                        >
                            {({ values, submitForm }) => (
                                <Form style={{ display: 'flex', flexDirection: 'column' }}>
                                    <Field type="name" name="name" palceholder={"Name identifier"} />
                                    <Field as="select" name="type" onChange={onTypeChange}>
                                        {Object.values(TYPE_NAMES)
                                            .map((key: string) => <option value={key}>
                                                {TYPES_MAPPING[key].label}
                                            </option>)
                                        }
                                    </Field>
                                    <ContentTypeField selected={"test"} />
                                    <div role="group" aria-labelledby="my-radio-group">
                                        Required
                                        <label>
                                            <Field type="radio" name="isRequired" value="true" />
                                            Yes
                                        </label>
                                        <label>
                                            <Field type="radio" name="isRequired" value="false" />
                                            No
                                        </label>
                                    </div>
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