
import { useQuery } from "@apollo/client";
import { userId } from "../../constants";
import { GET_ORGANIZATIONS } from "../../gql/queries.graphql";
import { Organizations } from "../../gql/__generated__/Organizations";

const OrganizationsList = () => {
    const { loading, error, data } = useQuery<Organizations>(GET_ORGANIZATIONS,
        { variables: { userId } });


    return (
        !loading && data ? (
            <div>
                {data.organizationsByUser.map((d: any) => JSON.stringify(d))}
            </div>) : <div>loading</div>

    )
}

export default OrganizationsList;