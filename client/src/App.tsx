import CorporateFare from '@mui/icons-material/CorporateFare';
import { Box, Divider, List, ListItem, ListItemButton, ListItemIcon, ListItemText, Toolbar } from '@mui/material';
import Drawer from '@mui/material/Drawer';
import { Link, Outlet } from "react-router-dom";

function App() {

  const drawerWidth = 240;
  const drawer = (
    <div>
      <Toolbar />
      <Divider />
      <List>
        {['Organizations'].map((text, index) => (
          <ListItem key={text} disablePadding>
            <Link style={{ textDecoration: 'none' }} to={'organizations'}>
              <ListItemButton>
                <ListItemIcon>
                  <CorporateFare />
                </ListItemIcon>
                <ListItemText primary={text} />
              </ListItemButton>
            </Link>
          </ListItem>
        ))}
      </List>
    </div>
  );

  return (
    <Box
      display={'flex'}
      flexDirection='row'>
      <Box width={drawerWidth}>
        <Drawer
          variant="permanent"
          open
        >
          {drawer}
        </Drawer>
      </Box>
      <Box width={`calc(100% - ${drawerWidth}px)`}>
        <Outlet />
      </Box>
    </Box>
  );
}

export default App;
