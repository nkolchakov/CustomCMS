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
export const ENTITES_NESTED_CHILDREN = gql`
    fragment EntityChildrenFields on ContentTypeNestedChildrenDto{
        id,
        name,
        description
    }
`
// MAX 5 levels of nesting.
// https://hashinteractive.com/blog/graphql-recursive-query-with-fragments/
export const ENTITES_RERCURSIVE = gql`
fragment EntityChildrenRecursive on ContentTypeNestedChildrenDto{
    children{
        ...EntityChildrenFields
        children {
            ...EntityChildrenFields
            children {
                ...EntityChildrenFields
                children {
                    ...EntityChildrenFields
                    children {
                        ...EntityChildrenFields
                    }
                }
            }
        }
    }
}
`
export const QUERY_SINGLE_ENTITY = gql`
${ENTITES_NESTED_CHILDREN}
${ENTITES_RERCURSIVE}
query EntityById($id: UUID!){
    entityById(id: $id){
      basicFields {
        id,
        name,
        value, 
        type,
        listItems {
            id,
            value
        }
      },
      ...EntityChildrenFields,
      ...EntityChildrenRecursive
    }
}
`
