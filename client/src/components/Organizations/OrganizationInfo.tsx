import { useParams } from "react-router-dom";
import SpacesList from "../Spaces/SpacesList";

export const OrganizationInfo = () => {
    const { organizationId } = useParams();

    return (
        <div>
            Organization info {organizationId}
            <SpacesList />
        </div>
    )
}

export default OrganizationInfo;