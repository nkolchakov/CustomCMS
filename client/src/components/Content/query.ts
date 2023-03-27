import { gql } from "@apollo/client";

export const QUERY_ENTITES = gql`
query EntitiesBySpace($spaceId: UUID!){
    entitiesBySpace(spaceId: $spaceId){
        id,
        name,
        description
    }
}
`