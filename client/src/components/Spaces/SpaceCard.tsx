import { useMutation } from "@apollo/client";
import { Card, CardActionArea, CardMedia, CardContent, Typography, Button, CardActions, Box } from "@mui/material";
import { Link } from "react-router-dom";
import { DeleteSpacePayload, MutationDeleteSpaceArgs, SpaceDto } from "../../generated-gql/graphql";
import { DELETE_SPACE } from "./mutation";

const SpaceCard = ({ spaceData }: { spaceData: SpaceDto }) => {

    const [mutationFunction, { data, loading, error }]
        = useMutation<DeleteSpacePayload, MutationDeleteSpaceArgs>(DELETE_SPACE,
            {
                errorPolicy: "all",
                onCompleted: () => {

                },
                onError: () => {

                }
            });

    const handleDelete = () => {
        const doDelete = window.confirm("Are you sure you want to delete ?");
        if (!doDelete) {
            return;
        }
        mutationFunction({
            variables: {
                input: {
                    spaceId: spaceData.id
                }
            }
        })
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
                        onClick={handleDelete}
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