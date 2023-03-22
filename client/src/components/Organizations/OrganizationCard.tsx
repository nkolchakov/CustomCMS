import { Card, CardActionArea, CardMedia, CardContent, Typography, Button, CardActions, Box } from "@mui/material";
import { OrganizationDto } from "../../generated/graphql.tsx/graphql";

const OrganizationCard = ({ organizationData }: { organizationData: OrganizationDto }) => {

    const handleDelete = () => {

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
                        onClick={handleDelete}
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