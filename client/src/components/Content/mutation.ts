import { gql } from "@apollo/client";

export const NEW_CONTENT_TYPE = gql`
    mutation CreateContentType($input: CreateContentTypeInput!){
            createContentType(input: $input){
                id,
                name,
                description,
                spaceId
            }
    } 
`