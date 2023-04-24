import { DateTimePicker } from '@mui/x-date-pickers';
import { AdapterMoment } from '@mui/x-date-pickers/AdapterMoment';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { Field } from "formik";
import { ReactElement } from "react";
import { TYPE_NAMES } from '../../constants';
import { StyledField } from "../Content/styles";
import { ChipsArray } from "./ChipsArray";

export type SetFieldValueCallback = (field: string, value: any, shouldValidate?: boolean) => void;
interface DynamicFieldProps {
    label: string,
    description: string,
    component: (valueName: string,
        fieldValue?: any,
        setFieldValueCb?: SetFieldValueCallback) => ReactElement | null;
}

export const TYPES_MAPPING: Record<string, DynamicFieldProps> = {
    [TYPE_NAMES.Text]: {
        label: "Text",
        description: "Free text field",
        component: (valueName: string = TYPE_NAMES.Text) => (<StyledField name={valueName} />)
    },
    [TYPE_NAMES.Number]: {
        label: "Number",
        description: "Any numerical values",
        component: (valueName: string = TYPE_NAMES.Number) => (<StyledField type='number' name={valueName} />)
    },
    [TYPE_NAMES.DateTime]: {
        label: "Date Time",
        description: "Date and time field",
        component: (valueName: string = TYPE_NAMES.DateTime, fieldValue?: any, setFieldValueCb?: Function) =>
        (<Field name={valueName} component={(props: any) =>
            <LocalizationProvider dateAdapter={AdapterMoment}>
                <DateTimePicker
                    value={fieldValue}
                    onChange={(value: any) => {
                        console.log(valueName, value)
                        if (setFieldValueCb) {
                            setFieldValueCb(valueName, value)
                        }
                    }}
                    label="Basic date time picker" />
            </LocalizationProvider>
        } />)
    },
    [TYPE_NAMES.Array]: {
        label: "List",
        description: "List of text entries (bullet points)",
        component: (valueName: string = TYPE_NAMES.Array, fieldValue, setFieldValueCb) => (
            <Field
                name={valueName}
                component={(props: any) =>
                    <ChipsArray
                        initialValues={new Set<string>(fieldValue)}
                        onChange={(values) => {
                            if (setFieldValueCb) {
                                setFieldValueCb(valueName, values)
                            }
                        }}
                    />}
            />
        )
    },
    [TYPE_NAMES.Asset]: {
        label: "File",
        description: "Any file to upload, up to to a limited MBs",
        component: (valueName: string = TYPE_NAMES.Asset, fieldValue, setFieldValueCb) =>
        (<Field
            type='file'
            onChange={(event: any) => {
                console.log(event.target.files)
                if (setFieldValueCb) {
                    setFieldValueCb(valueName, event.target.files[0])
                }
            }}
            name={TYPE_NAMES.Asset} />)

    },
    [TYPE_NAMES.Entry]: {
        label: "Content Type",
        description: "Add a reference/reuse to another created Content Type",
        component: (valueName: string = TYPE_NAMES.Entry) => null
    }
}

export const ContentTypeField = ({ selected }: any) => {
    return (
        <div>
            {selected}
        </div>
    )
}
