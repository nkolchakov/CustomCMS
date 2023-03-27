import { useQuery } from "@apollo/client";
import { DataGrid, GridRowParams, MuiEvent } from '@mui/x-data-grid';
import { Outlet, useNavigate, useParams } from "react-router-dom";
import { ContentTypeDto, EntitiesBySpaceQuery } from "../../generated-gql/graphql";
import { QUERY_ENTITES } from "../Content/query";
import { columns } from "./tableConfig";

const SpaceInfo = () => {
    const navigate = useNavigate();
    const { spaceId, entityId } = useParams();
    const { data, error, loading } = useQuery<EntitiesBySpaceQuery>(
        QUERY_ENTITES, {
        variables: {
            spaceId
        }
    })

    const tableView =
        loading ?
            <p>loading ...</p> :
            (data ? <div style={{
                minHeight: 500,
                height: '50vh',
                width: '100%'
            }}>
                <DataGrid
                    style={{ cursor: 'pointer' }}
                    rowSelection={false}
                    onRowClick={(params: GridRowParams<ContentTypeDto>, e: MuiEvent) => {
                        e.defaultMuiPrevented = true;
                        navigate(`entity/${params.row.id}`)
                        return;
                    }}
                    rows={data.entitiesBySpace}
                    columns={columns}
                    pageSizeOptions={[5]}
                />
            </div> : <p>no data</p>);

    return (
        <div>
            {!entityId && tableView}
            <Outlet />
        </div>

    )
}

export default SpaceInfo;