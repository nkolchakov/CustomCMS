import { TreeItem } from "@mui/lab";
import { Box, Button } from "@mui/material";
import { ContentTypeNestedChildrenDto, EntityByIdQuery } from "../../generated-gql/graphql";
import ArrowOutwardIcon from '@mui/icons-material/ArrowOutward';
import ChevronRightIcon from '@mui/icons-material/ChevronRight';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import TreeView from '@mui/lab/TreeView';
import { useLocation, useNavigate } from "react-router-dom";

const TreeNodeViewRedirect = ({ node }: { node: ContentTypeNestedChildrenDto }) => {
    const navigate = useNavigate();
    const location = useLocation();

    const handleForward = (e: any, entity: any) => {
        const anotherEntityUrl = location.pathname
            .replace(/\/[^\/]*$/, `/${entity.id}`);

        navigate(anotherEntityUrl, {
            replace: true
        });
    }

    return (
        <Box flexDirection={'column'}>
            <Button onClick={(e) => handleForward(e, node)}>
                {node.name}
                <ArrowOutwardIcon />
            </Button>
            {node.description}
        </Box>
    )
}

const renderTree = (nodes: ContentTypeNestedChildrenDto) => (
    <TreeItem
        key={nodes.id}
        nodeId={nodes.id}
        label={< TreeNodeViewRedirect node={nodes} />}>
        {
            Array.isArray(nodes.children)
                ? nodes.children.map((node) => renderTree(node))
                : null
        }
    </TreeItem >
);

export const EntityTreeView = ({ data }: { data: EntityByIdQuery }) => {
    const entityData = data?.entityById as ContentTypeNestedChildrenDto;
    return (
        <TreeView
            aria-label="rich object"
            defaultExpanded={['root']}
            defaultCollapseIcon={<ExpandMoreIcon />}
            defaultExpandIcon={<ChevronRightIcon />}
            style={{
                flexGrow: 1,
                height: "50vh",
            }}
        >
            {
                entityData.children.length > 0 &&
                renderTree(entityData)
            }
        </TreeView>)
}