import { GridColDef, GridRenderCellParams, GridValueGetterParams } from "@mui/x-data-grid";
import { CSSProperties } from "react";
import CopyToClipboardButton from "../common/CopyToClipboardButton";

const cellStyle: CSSProperties = {
    display: 'flex',
    width: '100%',
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center'
}

export const columns: GridColDef[] = [
    {
        field: 'id',
        headerName: 'Id',
        width: 150,
        sortable: false,
        align: 'center',
        renderCell: (params: GridRenderCellParams) => {
            const idStr = params.row.id.toString();
            const s = `${idStr.substring(0, 5)}...${idStr.substring(idStr.length - 3, idStr.length)}`
            return (
                <div style={cellStyle}>
                    {s} <CopyToClipboardButton text={params.row.id} />
                </div>
            )
        }
    },
    {
        field: 'name',
        headerName: 'Entity Name ID',
        description: 'The given unique name of the content type (entity).',
        width: 250,
        renderCell: (params: GridRenderCellParams) => {
            return (
                <div style={cellStyle}>
                    <strong> {params.row.name}</strong>
                    <CopyToClipboardButton text={params.row.name} />
                </div>
            )
        }
    },
    {
        field: 'description',
        headerName: 'Description',
        description: 'Description of the content type (entity).',
        sortable: false,
        width: 500,
        valueGetter: (params: GridValueGetterParams) =>
            params.value ? params.value : '<>'
        ,
        renderCell: (params: GridRenderCellParams) =>
            <p style={{ fontStyle: 'italic' }}>
                {params.formattedValue}
            </p>

    },
];
