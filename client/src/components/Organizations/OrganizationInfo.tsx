import { useContext, useEffect } from "react";
import { Outlet, useParams } from "react-router-dom";
import { CMSContext, CMSContextType } from "../../CMSContext";
import SpacesList from "../Spaces/SpacesList";

export const OrganizationInfo = () => {
    const { organizationId, spaceId } = useParams();

    const { setOrganizationId } = useContext(CMSContext) as CMSContextType;

    useEffect(() => {
        if (organizationId) {
            setOrganizationId(organizationId)
        }
    }, [organizationId])
    return (
        <div>
            {!spaceId &&
                (
                    <div>
                        Organization info {organizationId}
                        <SpacesList />
                    </div>
                )
            }
            <Outlet />
        </div>
    )
}

export default OrganizationInfo;