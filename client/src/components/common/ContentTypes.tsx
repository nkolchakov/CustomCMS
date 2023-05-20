import { DateTimePicker } from '@mui/x-date-pickers';
import { AdapterMoment } from '@mui/x-date-pickers/AdapterMoment';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { Field } from "formik";
import { ReactElement } from "react";
import { TYPE_NAMES } from '../../constants';
import { BasicFieldDto, Cms_Type } from '../../generated-gql/graphql';
import { StyledField } from "../Content/styles";
import { ChipData, ChipsArray } from "./ChipsArray";

export type SetFieldValueCallback = (field: string, value: any, shouldValidate?: boolean) => void;
interface DynamicFieldProps {
    label: string,
    description: string,
    component: (valueName: string,
        field?: BasicFieldDto,
        setFieldValueCb?: SetFieldValueCallback) => ReactElement | null;
}

export const TYPES_MAPPING: Record<string, DynamicFieldProps> = {
    [TYPE_NAMES.Text]: {
        label: "Text",
        description: "Free text field",
        component: (valueName: string = Cms_Type.Text) => (<StyledField name={valueName} />)
    },
    [TYPE_NAMES.Number]: {
        label: "Number",
        description: "Any numerical values",
        component: (valueName: string = Cms_Type.Number) => (<StyledField type='number' name={valueName} />)
    },
    [TYPE_NAMES.DateTime]: {
        label: "Date Time",
        description: "Date and time field",
        component: (valueName: string = Cms_Type.DateTime, field?: BasicFieldDto, setFieldValueCb?: Function) =>
        (<Field name={valueName} component={(props: any) =>
            <LocalizationProvider dateAdapter={AdapterMoment}>
                <DateTimePicker
                    value={field?.value}
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
        component: (valueName: string = Cms_Type.Array, field, setFieldValueCb) => {
            let accumulatedData: ChipData[] = [];
            if (field?.listItems && field.listItems.length > 0) {
                accumulatedData = [...field!.listItems!];
            }
            let newlyAddedFromInput = null;
            if (field?.value) {
                if (typeof field?.value === 'string') {
                    newlyAddedFromInput = JSON.parse(field.value);
                } else if (typeof field?.value === 'object') {
                    newlyAddedFromInput = field.value;
                }
            }
            if (newlyAddedFromInput) {
                accumulatedData.push(...newlyAddedFromInput);
            }
            return <Field
                name={valueName}
                component={(props: any) =>
                    <ChipsArray
                        initialValues={accumulatedData}
                        onChange={(values) => {
                            if (setFieldValueCb) {
                                setFieldValueCb(valueName, values)
                            }
                        }}
                    />}
            />
        }
    },
    [TYPE_NAMES.Asset]: {
        label: "File",
        description: "Any file to upload, up to to a limited MBs",
        component: (valueName: string = Cms_Type.Asset, _, setFieldValueCb) =>
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
        component: (valueName: string = Cms_Type.Entry) => null
    }
}

export const ContentTypeField = ({ selected }: any) => {
    return (
        <div>
            {selected}
        </div>
    )
}
