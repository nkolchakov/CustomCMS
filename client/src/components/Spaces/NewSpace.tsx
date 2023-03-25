import { Card, CardActionArea, CardContent, Box, Typography, Modal, TextField, Button } from "@mui/material";
import AddCircleIcon from '@mui/icons-material/AddCircle';
import { useState } from "react";
import { createElModalStyle } from "../../common/styles";
import * as yup from 'yup';
import { CreateSpacePayload, MutationCreateSpaceArgs } from "../../generated-gql/graphql";
import { NEW_SPACE } from "../Organizations/mutation";
import { useMutation } from "@apollo/client";
import { useFormik } from "formik";

const NewSpace = ({ currentOrganization }: { currentOrganization: string }) => {
    const [open, setOpen] = useState(false);
    const handleOpen = () => {
        setOpen(true);
    };
    const handleClose = () => {
        setOpen(false);
    };

    const [mutationFunction, { data, loading, error, ...result }]
        = useMutation<CreateSpacePayload, MutationCreateSpaceArgs>(NEW_SPACE,
            {
                errorPolicy: "all",
                onCompleted: () => {
                    console.log('completed ')
                    formik.resetForm();
                    handleClose();
                },
                onError: ({ graphQLErrors, networkError, ...rest }) => {
                    console.log(data, error, result);
                    console.error("error occured on saving an organization ", graphQLErrors, networkError, rest);
                }
            });


    const handleCreate = (values: any) => {
        mutationFunction({
            variables: {
                input: {
                    name: values.name,
                    organizationId: currentOrganization
                }
            }
        });
    }

    const validationSchema = yup.object({
        name: yup.string()
            .required("Space name is required !")
    });


    const formik = useFormik({
        initialValues: {
            name: ""
        },
        validationSchema: validationSchema,
        onSubmit: (values) => {
            handleCreate(values);
        },
    });

    return (
        <div style={{ alignSelf: 'center' }}>
            <Card sx={{ width: 345 }}>
                <CardActionArea onClick={handleOpen}>
                    <CardContent>
                        <Box flexDirection={'column'} textAlign='center'>
                            <Typography gutterBottom variant="h5" component="div">
                                New Space
                            </Typography>
                            <AddCircleIcon color='primary' />
                        </Box>
                    </CardContent>
                </CardActionArea>
            </Card>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="create a new Space"
                aria-describedby="create a new Space"
            >
                <Box sx={{ ...createElModalStyle, width: 400 }} rowGap={3} columnGap={3}>
                    <h2 id="parent-modal-title">Create Space</h2>
                    {loading ? '...' :
                        <form onSubmit={formik.handleSubmit}>
                            <TextField
                                id="name"
                                type="name"
                                name="name"
                                label="Space name"
                                variant={'standard'}
                                value={formik.values.name}
                                onChange={formik.handleChange}
                                error={formik.touched.name && Boolean(formik.errors.name)}
                                helperText={formik.touched.name && formik.errors.name}
                            />
                            <br />
                            <Button
                                style={{ marginTop: 20 }}
                                type='submit'
                                variant="contained">
                                Create
                            </Button>
                        </form>
                    }
                </Box>
            </Modal>
        </div>
    )
}

export default NewSpace;
