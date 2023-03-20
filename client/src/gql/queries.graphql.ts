import { gql } from "@apollo/client";

export const GET_ORGANIZATIONS = gql`
query Organizations($userId: UUID!) {
    organizationsByUser(userId: $userId) {
               id,
               name,
               spaces {
                   id,
                   name
               }
           }
}`
