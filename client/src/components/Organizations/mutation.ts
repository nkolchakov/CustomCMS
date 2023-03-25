import { gql } from "@apollo/client";

export const NEW_ORGANIZATION = gql`
    mutation CreateOrganization($input: CreateOrganizationInput!){
            createOrganization(input: $input){
                id,
                name
            }
    } 
`

export const DELETE_ORGANIZATION = gql`
    mutation DeleteOrganization($input: DeleteOrganizationInput!) {
        deleteOrganization(input: $input) {
            boolean
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