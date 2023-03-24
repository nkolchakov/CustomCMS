import { Card, CardActionArea, CardMedia, CardContent, Typography, Button, CardActions, Box } from "@mui/material";
import { Link } from "react-router-dom";
import { SpaceDto } from "../../generated-gql/graphql";

const SpaceCard = ({ spaceData }: { spaceData: SpaceDto }) => {

    // const [mutationFunction, { data, loading, error }]
    //     = useMutation<DeleteOrganizationPayload, MutationDeleteOrganizationArgs>(DELETE_ORGANIZATION,
    //         {
    //             errorPolicy: "all",
    //             onCompleted: () => {

    //             },
    //             onError: () => {

    //             }
    //         });

    const handleDelete = () => {
        // if (orgId) {
        //     const doDelete = window.confirm("Are you sure you want to delete ?");
        //     if (!doDelete) {
        //         return;
        //     }
        //     mutationFunction({
        //         variables: {
        //             input: {
        //                 organizationId: orgId,
        //                 userId
        //             }
        //         }
        //     })
        // }
    };

    return (
        <Card sx={{ width: 300 }}>
            <Box display={'flex'}
                flexDirection='column'>
                <CardActionArea>
                    <Link
                        style={{ textDecoration: 'none' }}
                        to={`/space/${spaceData.id}`}
                    >
                        <CardMedia
                            component="img"
                            height='120px'
                            image="/container.png"
                            alt="namespace image"
                            style={{ objectFit: 'contain' }}
                        />
                        <CardContent>
                            <Typography gutterBottom variant="h5" component="div">
                                {spaceData.name}
                            </Typography>
                            <Typography variant="body2" color="text.secondary">
                                Entries ...
                            </Typography>
                        </CardContent>
                    </Link>
                </CardActionArea>
                <CardActions>
                    <Button
                        onClick={() => handleDelete()}
                        size="medium"
                        style={{ color: 'red', fontWeight: 700 }}>
                        Delete
                    </Button>
                </CardActions>
            </Box>
        </Card >
    );
};

export default SpaceCard;