import { Outlet, useParams } from "react-router-dom";
import SpacesList from "../Spaces/SpacesList";

export const OrganizationInfo = () => {
    const { organizationId, spaceId } = useParams();

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