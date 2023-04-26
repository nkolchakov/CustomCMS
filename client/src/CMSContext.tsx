import { createContext, FC, PropsWithChildren, useState } from 'react';

export type CMSContextType = {
    organizationId: string,
    setOrganizationId: Function,
    spaceId: string,
    setSpaceId: Function,
    refreshEntitiesList: boolean,
    setRefreshEntitiesList: Function
}

export const CMSContext = createContext<CMSContextType | null>(null);

const CMSContextProvider: FC<PropsWithChildren> = ({ children }) => {
    const [organizationId, setOrganizationId] = useState("")
    const [spaceId, setSpaceId] = useState("");
    const [refreshEntitiesList, setRefreshEntitiesList] = useState(false)
    return (
        <CMSContext.Provider value={{
            organizationId,
            setOrganizationId,
            spaceId,
            setSpaceId,
            refreshEntitiesList,
            setRefreshEntitiesList
        }}>
            {children}
        </CMSContext.Provider>
    )
}

export default CMSContextProvider;