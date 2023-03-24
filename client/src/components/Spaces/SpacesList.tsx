import { useQuery } from "@apollo/client";
import { QUERY_SPACES } from "./query";
import { useParams } from "react-router-dom";
import { SpacesQuery } from "../../generated-gql/graphql";
import SpaceCard from "./SpaceCard";

const SpacesList = () => {
    const { organizationId } = useParams();


    const { data, loading, error } = useQuery<SpacesQuery>(QUERY_SPACES, {
        variables: {
            organizationId
        }
    })

    return (
        <div>
            {data?.spacesByOrganization.length === 0 ? "No Spaces inside the organization" : null}
            {data?.spacesByOrganization.map((s, i) => <SpaceCard key={i} spaceData={s} />)}
        </div>
    )
}

export default SpacesList;