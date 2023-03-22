import { gql } from "@apollo/client";

export const NEW_ORGANIZATION = gql`
    mutation CreateOrganization($input: CreateOrganizationInput!){
            createOrganization(input: $input){
                id,
                name
            }
    } 
`