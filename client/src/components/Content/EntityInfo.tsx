import { useParams } from "react-router-dom";

const EntityInfo = () => {
    const { entityId } = useParams();


    return (
        <div>
            entity info for {entityId}
        </div>
    )
}

export default EntityInfo;