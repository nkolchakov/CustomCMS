import { gql } from "@apollo/client";

export const QUERY_SPACES = gql`
query Spaces($organizationId: UUID!){
    spacesByOrganization(organizationId: $organizationId){
        id,
        name
    }
}
`

export const NEW_SPACE = gql`
    mutation CreateSpace($input: CreateSpaceInput!){
        createSpace(input: $input){
            id,
            name
        }
    }
`