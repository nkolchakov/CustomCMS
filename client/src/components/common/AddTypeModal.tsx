import { Modal, Box, Button } from "@mui/material";
import { Formik, Field } from "formik";
import { useState } from "react";
import { Form } from "react-router-dom";
import { createElModalStyle } from "../../common/styles";
import { TYPE_NAMES } from "../../constants";
import { TYPES_MAPPING } from "./ContentTypes";


interface AddDynamicTypeModalProps {
    open: boolean,
    onClose: () => void,
    onSubmit: (values: any) => void,
    onAddInput: (selectedType: string) => void,
    isLoading?: boolean
}

export const AddDynamicTypeModal = ({
    open,
    onClose,
    onSubmit,
    onAddInput,
    isLoading = false,
}: AddDynamicTypeModalProps) => {
    const [selectedType, setSelectedType] = useState('')

    return (
        <Modal
            open={open}
            onClose={onClose}
            aria-labelledby="Add new field"
            aria-describedby="Add new field"
        >
            <Box sx={{
                ...createElModalStyle,
                width: 400
            }}
                rowGap={3}
                columnGap={3}>
                <h2 id="parent-modal-title">Add new field</h2>
                {isLoading ? '...' :
                    <Formik
                        initialValues={{}}
                        onSubmit={onSubmit}
                    >
                        {({ values, submitForm }) => (
                            <Form style={{ display: 'flex', flexDirection: 'column' }}>
                                <Field as="select" name="type"
                                    onChange={(e: any) => setSelectedType(e.target.value)}>
                                    {Object.values(TYPE_NAMES)
                                        .map((key: string) =>
                                            <option key={key} value={key}>
                                                {TYPES_MAPPING[key].label}
                                            </option>)
                                    }
                                </Field>
                                {selectedType && <p>{TYPES_MAPPING[selectedType].description}</p>}
                                <Button
                                    onClick={() => {
                                        onAddInput(selectedType);
                                        onClose()
                                    }}
                                    style={{ width: '50px', marginTop: '10px' }}
                                    type="submit"
                                    size='small'
                                    variant='contained'>
                                    Add
                                </Button>
                            </Form>
                        )}
                    </Formik>
                }
            </Box>
        </Modal>
    )
}