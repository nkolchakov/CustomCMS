import { Modal, Box, Button } from "@mui/material";
import { Formik, Field } from "formik";
import { useState } from "react";
import { Form } from "react-router-dom";
import { createElModalStyle } from "../../common/styles";
import { TYPE_NAMES } from "../../constants";
import { Cms_Type } from "../../generated-gql/graphql";
import { TYPES_MAPPING } from "./ContentTypes";


interface AddDynamicTypeModalProps {
    open: boolean,
    onClose: () => void,
    onSubmit: (values: any) => void,
    onAddInput: (selectedType: number) => void,
    isLoading?: boolean
}

export const AddDynamicTypeModal = ({
    open,
    onClose,
    onSubmit,
    onAddInput,
    isLoading = false,
}: AddDynamicTypeModalProps) => {
    const [selectedType, setSelectedType] = useState<number>(0)

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
                                    {Object.values(Cms_Type)
                                        .map((key: string, index: number) =>
                                            <option key={key} value={index}>
                                                {TYPES_MAPPING[index].label}
                                            </option>)
                                    }
                                </Field>
                                {selectedType !== undefined && <p>{TYPES_MAPPING[selectedType].description}</p>}
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