import { useQuery } from "@apollo/client";
import { QUERY_SPACES } from "./query";
import { useParams } from "react-router-dom";
import { SpacesQuery } from "../../generated-gql/graphql";
import SpaceCard from "./SpaceCard";
import NewSpace from "./NewSpace";
import { Box } from "@mui/material";

const SpacesList = () => {
    const { organizationId } = useParams();


    const { data, loading, error } = useQuery<SpacesQuery>(QUERY_SPACES, {
        variables: {
            organizationId
        }
    })

    return (
        <Box
            flexWrap={'wrap'}
            display={'flex'}
            flexDirection='row'
            rowGap={3} columnGap={3}
            padding={'10px 0 10px 0'}
            maxWidth={'70wh'}
        >
            {organizationId && <NewSpace currentOrganization={organizationId} />}
            {data?.spacesByOrganization.length === 0 ? "No Spaces inside the organization" : null}
            {data?.spacesByOrganization.map((s, i) => <SpaceCard key={i} spaceData={s} />)}
        </Box>
    )
}

export default SpacesList;