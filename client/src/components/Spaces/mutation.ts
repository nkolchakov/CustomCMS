import { gql } from "@apollo/client";

export const DELETE_SPACE = gql`
    mutation DeleteSpace($input: DeleteSpaceInput!) {
        deleteSpace(input: $input) {
            boolean
        }
    }
`