
import { useQuery } from "@apollo/client";
import { Box } from "@mui/material";
import { userId } from "../../constants";
import { OrganizationsQuery } from "../../generated/graphql.tsx/graphql";
import NewOrganization from "./NewOrganization";
import OrganizationCard from "./OrganizationCard";
import { QUERY_ORGANIZATIONS } from "./query";

const OrganizationsList = () => {
    const { loading, error, data } = useQuery<OrganizationsQuery>(QUERY_ORGANIZATIONS,
        { variables: { userId } });

    return (
        !loading && data ? (
            <Box
                flexWrap={'wrap'}
                display={'flex'}
                flexDirection='row'
                rowGap={3} columnGap={3}
                padding={'10px 0 10px 0'}
                maxWidth={'70wh'}
            >
                <NewOrganization />
                {data.organizationsByUser.map(d => <OrganizationCard organizationData={d} />)}
            </Box>
        ) : <div>loading</div>

    )
}

export default OrganizationsList;