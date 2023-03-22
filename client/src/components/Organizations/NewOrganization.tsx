import { Box, Button, Card, CardActionArea, CardContent, IconButton, Modal, TextField, Typography } from "@mui/material";
import AddCircleIcon from '@mui/icons-material/AddCircle';
import { useState } from "react";
import { Formik, Form, Field, ErrorMessage, useFormik } from 'formik';
import * as yup from 'yup';
import { FormGroup } from '@mui/material';
import { useMutation } from "@apollo/client";
import { NEW_ORGANIZATION } from "./mutation";
import { CreateOrganizationMutation, CreateOrganizationMutationVariables, MutationCreateOrganizationArgs } from "../../generated/graphql.tsx/graphql";
import { userId } from "../../constants";

const NewOrganization = () => {
    const [open, setOpen] = useState(false);
    const handleOpen = () => {
        setOpen(true);
    };
    const handleClose = () => {
        setOpen(false);
    };

    const modalStyle = {
        position: 'absolute' as 'absolute',
        top: '50%',
        left: '50%',
        transform: 'translate(-50%, -50%)',
        width: 400,
        bgcolor: 'background.paper',
        borderRadius: '5px',
        boxShadow: 24,
        pt: 2,
        px: 4,
        pb: 3,
    };

    const [mutationFunction, { data, loading, error, ...result }]
        = useMutation<CreateOrganizationMutation, CreateOrganizationMutationVariables>(NEW_ORGANIZATION,
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


    const validationSchema = yup.object({
        name: yup.string()
            .required("Organizations name is required !")
    });


    const formik = useFormik({
        initialValues: {
            name: ''
        },
        validationSchema: validationSchema,
        onSubmit: (values) => {
            handleCreate(values);
        },
    });

    const handleCreate = (values: any) => {
        mutationFunction({
            variables: {
                input: {
                    organizationName: values.name,
                    userId: userId
                }
            }
        });
    }
    return (
        <div style={{ alignSelf: 'center' }}>
            <Card sx={{ width: 345 }}>
                <CardActionArea onClick={handleOpen}>
                    <CardContent>
                        <Box flexDirection={'column'} textAlign='center'>
                            <Typography gutterBottom variant="h5" component="div">
                                New Organization
                            </Typography>
                            <AddCircleIcon color='primary' />
                        </Box>
                    </CardContent>
                </CardActionArea>
            </Card>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="create a new organization"
                aria-describedby="create a new organization"
            >
                <Box sx={{ ...modalStyle, width: 400 }} rowGap={3} columnGap={3}>
                    <h2 id="parent-modal-title">Create Organization</h2>
                    {loading ? '...' :
                        <form onSubmit={formik.handleSubmit}>
                            <TextField
                                id="name"
                                type="name"
                                name="name"
                                label="Organization name"
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
                                Submit
                            </Button>
                        </form>
                    }
                </Box>
            </Modal>
        </div>
    )
}

export default NewOrganization;