export const getEntityUrl = (organizationId: string, spaceId: string, entityId: string) => {
    return `/organization/${organizationId}/space/${spaceId}/entity/${entityId}`;
}