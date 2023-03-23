import { useMutation } from "@apollo/client";
import { Card, CardActionArea, CardMedia, CardContent, Typography, Button, CardActions, Box } from "@mui/material";
import { userId } from "../../constants";
import { DeleteOrganizationInput, DeleteOrganizationPayload, MutationDeleteOrganizationArgs, OrganizationDto } from "../../generated/graphql.tsx/graphql";
import { DELETE_ORGANIZATION } from "./mutation";

const OrganizationCard = ({ organizationData }: { organizationData: OrganizationDto }) => {

    const [mutationFunction, { data, loading, error }]
        = useMutation<DeleteOrganizationPayload, MutationDeleteOrganizationArgs>(DELETE_ORGANIZATION,
            {
                errorPolicy: "all",
                onCompleted: () => {

                },
                onError: () => {

                }
            });

    const handleDelete = (orgId: string) => {
        if (orgId) {
            const doDelete = window.confirm("Are you sure you want to delete ?");
            if (!doDelete) {
                return;
            }
            mutationFunction({
                variables: {
                    input: {
                        organizationId: orgId,
                        userId
                    }
                }
            })
        }
    };

    return (
        <Card sx={{ width: 345 }}>
            <Box display={'flex'} flexDirection='column'>
                <CardActionArea>
                    <CardMedia
                        component="img"
                        height="140"
                        image="./structure.jpg"
                        alt="green iguana"
                    />
                    <CardContent>
                        <Typography gutterBottom variant="h5" component="div">
                            {organizationData.name}
                        </Typography>
                        <Typography variant="body2" color="text.secondary">
                            users: <br></br>{organizationData.users.map(d => d!.id).join('\n')}
                        </Typography>
                    </CardContent>
                </CardActionArea>
                <CardActions>
                    <Button
                        onClick={() => handleDelete(organizationData.id)}
                        size="medium"
                        style={{ color: 'red', fontWeight: 700 }}>
                        Delete
                    </Button>
                </CardActions>
            </Box>
        </Card>
    );
};

export default OrganizationCard;