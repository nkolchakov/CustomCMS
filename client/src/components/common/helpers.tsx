import moment from "moment";
import { EMPTY_GUID, TYPE_NAMES } from "../../constants";
import { BasicFieldDto, Cms_Type } from "../../generated-gql/graphql";

export const getEntityUrl = (organizationId: string, spaceId: string, entityId: string) => {
    return `/organization/${organizationId}/space/${spaceId}/entity/${entityId}`;
}

export const isValidGuid = (value: string): boolean => {
    if (value?.length > 0) {
        if (value === EMPTY_GUID) {
            return false;
        } else if (!(/^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$/).test(value)) {
            return false;
        }
        return true;
    }

    return false;
}
const toBase64 = (file: any): Promise<any> => new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = reject;
});

export const serializeField = async (field: BasicFieldDto) => {
    let serialized = "";
    switch (field.type.toUpperCase()) {
        case Cms_Type.Asset:
            serialized = await toBase64(field.value);
            break;
        case Cms_Type.DateTime:
            serialized = moment(field.value).utc().valueOf().toString();
            break;
        case Cms_Type.Text:
            serialized = field.value;
            break;
        default:
            serialized = JSON.stringify(field.value);
            break;
    }
    return serialized;
}