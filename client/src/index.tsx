import { ApolloClient, ApolloProvider, InMemoryCache } from '@apollo/client';
import React from 'react';
import ReactDOM from 'react-dom/client';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import App from './App';
import ErrorPage from './ErrorPage';
import OrganizationsList from './components/Organizations/OrganizationsList';
const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
const client = new ApolloClient({
  uri: 'https://localhost:7010/graphql',
  cache: new InMemoryCache(),
});

// apolloq queries conflicts with the new loader pattern.
// https://community.apollographql.com/t/how-to-load-data-with-react-router-dom-v6-and-handling-errorpage/5347/10
// will skip loader 

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <ErrorPage />,
    children: [
      {
        path: "organizations",
        element: <OrganizationsList />,
        // loader: () => getOrganizationsListForUser(userId)
      }
    ]
  }
]);

root.render(
  <ApolloProvider client={client}>
    <React.StrictMode>
      <RouterProvider router={router} />
    </React.StrictMode>
  </ApolloProvider>
);
