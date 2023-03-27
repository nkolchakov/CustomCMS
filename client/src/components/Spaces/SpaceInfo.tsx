import { useParams } from "react-router-dom";

const SpaceInfo = () => {
    const { spaceId } = useParams();

    return (
        <div>Info for space {spaceId}</div>
    )
}

export default SpaceInfo;