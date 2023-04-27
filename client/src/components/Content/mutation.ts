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
export const UPDATE_CONTENT_FIELDS = gql`
    mutation UpdateContentFields($input: UpdateContentFieldsInput!){
        updateContentFields(input: $input){
            boolean
        }
    }
`