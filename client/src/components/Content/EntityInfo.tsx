import { useQuery } from "@apollo/client";
import { useParams } from "react-router-dom";
import { QUERY_SINGLE_ENTITY } from "./query";

const EntityInfo = () => {
    const { entityId } = useParams();
    const { loading, error, data } = useQuery(QUERY_SINGLE_ENTITY, {
        variables: { id: entityId }
    });

    return (
        <div>
            entity info for {entityId}
            {JSON.stringify(data)}
        </div>
    )
}

export default EntityInfo;