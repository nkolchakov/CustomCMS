/* eslint-disable */
import * as types from './graphql';
import { TypedDocumentNode as DocumentNode } from '@graphql-typed-document-node/core';

/**
 * Map of all GraphQL operations in the project.
 *
 * This map has several performance disadvantages:
 * 1. It is not tree-shakeable, so it will include all operations in the project.
 * 2. It is not minifiable, so the string of a GraphQL query will be multiple times inside the bundle.
 * 3. It does not support dead code elimination, so it will add unused operations.
 *
 * Therefore it is highly recommended to use the babel or swc plugin for production.
 */
const documents = {
    "\nquery EntitiesBySpace($spaceId: UUID!){\n    entitiesBySpace(spaceId: $spaceId){\n        id,\n        name,\n        description\n    }\n}\n": types.EntitiesBySpaceDocument,
    "\n    fragment EntityChildrenFields on ContentTypeNestedChildrenDto{\n        id,\n        name,\n        description\n    }\n": types.EntityChildrenFieldsFragmentDoc,
    "\nfragment EntityChildrenRecursive on ContentTypeNestedChildrenDto{\n    children{\n        ...EntityChildrenFields\n        children {\n            ...EntityChildrenFields\n            children {\n                ...EntityChildrenFields\n                children {\n                    ...EntityChildrenFields\n                    children {\n                        ...EntityChildrenFields\n                    }\n                }\n            }\n        }\n    }\n}\n": types.EntityChildrenRecursiveFragmentDoc,
    "\n\n\nquery EntityById($id: UUID!){\n    entityById(id: $id){\n      basicFields {\n        name,\n        value\n      },\n      ...EntityChildrenFields,\n      ...EntityChildrenRecursive\n    }\n}\n": types.EntityByIdDocument,
    "\n    mutation CreateOrganization($input: CreateOrganizationInput!){\n            createOrganization(input: $input){\n                id,\n                name\n            }\n    } \n": types.CreateOrganizationDocument,
    "\n    mutation DeleteOrganization($input: DeleteOrganizationInput!) {\n        deleteOrganization(input: $input) {\n            boolean\n        }\n    }\n": types.DeleteOrganizationDocument,
    "\nquery Organizations($userId: UUID!) {\n    organizationsByUser(userId: $userId) {\n               id,\n               name,\n               spaces {\n                   id,\n                   name\n               },\n               users {\n                id,\n                userRole\n               }\n           }\n}": types.OrganizationsDocument,
    "\n    mutation DeleteSpace($input: DeleteSpaceInput!) {\n        deleteSpace(input: $input) {\n            boolean\n        }\n    }\n": types.DeleteSpaceDocument,
    "\nquery Spaces($organizationId: UUID!){\n    spacesByOrganization(organizationId: $organizationId){\n        id,\n        name\n    }\n}\n": types.SpacesDocument,
    "\n    mutation CreateSpace($input: CreateSpaceInput!){\n        createSpace(input: $input){\n            id,\n            name\n        }\n    }\n": types.CreateSpaceDocument,
};

/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 *
 *
 * @example
 * ```ts
 * const query = graphql(`query GetUser($id: ID!) { user(id: $id) { name } }`);
 * ```
 *
 * The query argument is unknown!
 * Please regenerate the types.
 */
export function graphql(source: string): unknown;

/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\nquery EntitiesBySpace($spaceId: UUID!){\n    entitiesBySpace(spaceId: $spaceId){\n        id,\n        name,\n        description\n    }\n}\n"): (typeof documents)["\nquery EntitiesBySpace($spaceId: UUID!){\n    entitiesBySpace(spaceId: $spaceId){\n        id,\n        name,\n        description\n    }\n}\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n    fragment EntityChildrenFields on ContentTypeNestedChildrenDto{\n        id,\n        name,\n        description\n    }\n"): (typeof documents)["\n    fragment EntityChildrenFields on ContentTypeNestedChildrenDto{\n        id,\n        name,\n        description\n    }\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\nfragment EntityChildrenRecursive on ContentTypeNestedChildrenDto{\n    children{\n        ...EntityChildrenFields\n        children {\n            ...EntityChildrenFields\n            children {\n                ...EntityChildrenFields\n                children {\n                    ...EntityChildrenFields\n                    children {\n                        ...EntityChildrenFields\n                    }\n                }\n            }\n        }\n    }\n}\n"): (typeof documents)["\nfragment EntityChildrenRecursive on ContentTypeNestedChildrenDto{\n    children{\n        ...EntityChildrenFields\n        children {\n            ...EntityChildrenFields\n            children {\n                ...EntityChildrenFields\n                children {\n                    ...EntityChildrenFields\n                    children {\n                        ...EntityChildrenFields\n                    }\n                }\n            }\n        }\n    }\n}\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n\n\nquery EntityById($id: UUID!){\n    entityById(id: $id){\n      basicFields {\n        name,\n        value\n      },\n      ...EntityChildrenFields,\n      ...EntityChildrenRecursive\n    }\n}\n"): (typeof documents)["\n\n\nquery EntityById($id: UUID!){\n    entityById(id: $id){\n      basicFields {\n        name,\n        value\n      },\n      ...EntityChildrenFields,\n      ...EntityChildrenRecursive\n    }\n}\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n    mutation CreateOrganization($input: CreateOrganizationInput!){\n            createOrganization(input: $input){\n                id,\n                name\n            }\n    } \n"): (typeof documents)["\n    mutation CreateOrganization($input: CreateOrganizationInput!){\n            createOrganization(input: $input){\n                id,\n                name\n            }\n    } \n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n    mutation DeleteOrganization($input: DeleteOrganizationInput!) {\n        deleteOrganization(input: $input) {\n            boolean\n        }\n    }\n"): (typeof documents)["\n    mutation DeleteOrganization($input: DeleteOrganizationInput!) {\n        deleteOrganization(input: $input) {\n            boolean\n        }\n    }\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\nquery Organizations($userId: UUID!) {\n    organizationsByUser(userId: $userId) {\n               id,\n               name,\n               spaces {\n                   id,\n                   name\n               },\n               users {\n                id,\n                userRole\n               }\n           }\n}"): (typeof documents)["\nquery Organizations($userId: UUID!) {\n    organizationsByUser(userId: $userId) {\n               id,\n               name,\n               spaces {\n                   id,\n                   name\n               },\n               users {\n                id,\n                userRole\n               }\n           }\n}"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n    mutation DeleteSpace($input: DeleteSpaceInput!) {\n        deleteSpace(input: $input) {\n            boolean\n        }\n    }\n"): (typeof documents)["\n    mutation DeleteSpace($input: DeleteSpaceInput!) {\n        deleteSpace(input: $input) {\n            boolean\n        }\n    }\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\nquery Spaces($organizationId: UUID!){\n    spacesByOrganization(organizationId: $organizationId){\n        id,\n        name\n    }\n}\n"): (typeof documents)["\nquery Spaces($organizationId: UUID!){\n    spacesByOrganization(organizationId: $organizationId){\n        id,\n        name\n    }\n}\n"];
/**
 * The graphql function is used to parse GraphQL queries into a document that can be used by GraphQL clients.
 */
export function graphql(source: "\n    mutation CreateSpace($input: CreateSpaceInput!){\n        createSpace(input: $input){\n            id,\n            name\n        }\n    }\n"): (typeof documents)["\n    mutation CreateSpace($input: CreateSpaceInput!){\n        createSpace(input: $input){\n            id,\n            name\n        }\n    }\n"];

export function graphql(source: string) {
  return (documents as any)[source] ?? {};
}

export type DocumentType<TDocumentNode extends DocumentNode<any, any>> = TDocumentNode extends DocumentNode<  infer TType,  any>  ? TType  : never;