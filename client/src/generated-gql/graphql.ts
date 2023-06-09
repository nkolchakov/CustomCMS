/* eslint-disable */
import { TypedDocumentNode as DocumentNode } from '@graphql-typed-document-node/core';
export type Maybe<T> = T | null;
export type InputMaybe<T> = Maybe<T>;
export type Exact<T extends { [key: string]: unknown }> = { [K in keyof T]: T[K] };
export type MakeOptional<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]?: Maybe<T[SubKey]> };
export type MakeMaybe<T, K extends keyof T> = Omit<T, K> & { [SubKey in K]: Maybe<T[SubKey]> };
/** All built-in and custom scalars, mapped to their actual values */
export type Scalars = {
  ID: string;
  String: string;
  Boolean: boolean;
  Int: number;
  Float: number;
  /** The `DateTime` scalar represents an ISO-8601 compliant date time type. */
  DateTime: any;
  UUID: any;
};

export type BasicField = {
  __typename?: 'BasicField';
  contentType: ContentType;
  contentTypeId: Scalars['UUID'];
  id: Scalars['UUID'];
  listItems: Array<ListItem>;
  name: Scalars['String'];
  required?: Maybe<Scalars['Boolean']>;
  type: Cms_Type;
  value?: Maybe<Scalars['String']>;
};

export type BasicFieldDto = {
  __typename?: 'BasicFieldDto';
  id: Scalars['UUID'];
  listItems?: Maybe<Array<ListItemDto>>;
  name: Scalars['String'];
  required?: Maybe<Scalars['Boolean']>;
  type: Scalars['Int'];
  value?: Maybe<Scalars['String']>;
};

export type BasicFieldDtoFilterInput = {
  and?: InputMaybe<Array<BasicFieldDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  listItems?: InputMaybe<ListFilterInputTypeOfListItemDtoFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<BasicFieldDtoFilterInput>>;
  required?: InputMaybe<BooleanOperationFilterInput>;
  type?: InputMaybe<IntOperationFilterInput>;
  value?: InputMaybe<StringOperationFilterInput>;
};

export type BasicFieldDtoInput = {
  id: Scalars['UUID'];
  listItems?: InputMaybe<Array<ListItemDtoInput>>;
  name: Scalars['String'];
  required?: InputMaybe<Scalars['Boolean']>;
  type: Scalars['Int'];
  value?: InputMaybe<Scalars['String']>;
};

export type BasicFieldFilterInput = {
  and?: InputMaybe<Array<BasicFieldFilterInput>>;
  contentType?: InputMaybe<ContentTypeFilterInput>;
  contentTypeId?: InputMaybe<UuidOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  listItems?: InputMaybe<ListFilterInputTypeOfListItemFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<BasicFieldFilterInput>>;
  required?: InputMaybe<BooleanOperationFilterInput>;
  type?: InputMaybe<Cms_TypeOperationFilterInput>;
  value?: InputMaybe<StringOperationFilterInput>;
};

export type BooleanOperationFilterInput = {
  eq?: InputMaybe<Scalars['Boolean']>;
  neq?: InputMaybe<Scalars['Boolean']>;
};

export enum Cms_Type {
  Array = 'ARRAY',
  Asset = 'ASSET',
  DateTime = 'DATE_TIME',
  Entry = 'ENTRY',
  Number = 'NUMBER',
  Text = 'TEXT'
}

export type Cms_TypeOperationFilterInput = {
  eq?: InputMaybe<Cms_Type>;
  in?: InputMaybe<Array<Cms_Type>>;
  neq?: InputMaybe<Cms_Type>;
  nin?: InputMaybe<Array<Cms_Type>>;
};

export type ContentType = {
  __typename?: 'ContentType';
  basicFields: Array<BasicField>;
  children: Array<ContentTypeReferences>;
  description?: Maybe<Scalars['String']>;
  id: Scalars['UUID'];
  name: Scalars['String'];
  parents: Array<ContentTypeReferences>;
  spaceId: Scalars['UUID'];
  sys?: Maybe<Sys>;
};

export type ContentTypeDto = {
  __typename?: 'ContentTypeDto';
  basicFields: Array<BasicFieldDto>;
  description?: Maybe<Scalars['String']>;
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type ContentTypeDtoFilterInput = {
  and?: InputMaybe<Array<ContentTypeDtoFilterInput>>;
  basicFields?: InputMaybe<ListFilterInputTypeOfBasicFieldDtoFilterInput>;
  description?: InputMaybe<StringOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeDtoFilterInput>>;
};

export type ContentTypeDtoSortInput = {
  description?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type ContentTypeFilterInput = {
  and?: InputMaybe<Array<ContentTypeFilterInput>>;
  basicFields?: InputMaybe<ListFilterInputTypeOfBasicFieldFilterInput>;
  children?: InputMaybe<ListFilterInputTypeOfContentTypeReferencesFilterInput>;
  description?: InputMaybe<StringOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeFilterInput>>;
  parents?: InputMaybe<ListFilterInputTypeOfContentTypeReferencesFilterInput>;
  spaceId?: InputMaybe<UuidOperationFilterInput>;
  sys?: InputMaybe<SysFilterInput>;
};

export type ContentTypeNestedChildrenDto = {
  __typename?: 'ContentTypeNestedChildrenDto';
  basicFields: Array<BasicFieldDto>;
  children: Array<ContentTypeNestedChildrenDto>;
  description?: Maybe<Scalars['String']>;
  id: Scalars['UUID'];
  level: Scalars['Int'];
  name: Scalars['String'];
  parentId?: Maybe<Scalars['UUID']>;
};

export type ContentTypeNestedChildrenDtoFilterInput = {
  and?: InputMaybe<Array<ContentTypeNestedChildrenDtoFilterInput>>;
  basicFields?: InputMaybe<ListFilterInputTypeOfBasicFieldDtoFilterInput>;
  children?: InputMaybe<ListFilterInputTypeOfContentTypeNestedChildrenDtoFilterInput>;
  description?: InputMaybe<StringOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  level?: InputMaybe<IntOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeNestedChildrenDtoFilterInput>>;
  parentId?: InputMaybe<UuidOperationFilterInput>;
};

export type ContentTypeNestedChildrenDtoSortInput = {
  description?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  level?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
  parentId?: InputMaybe<SortEnumType>;
};

export type ContentTypeReferences = {
  __typename?: 'ContentTypeReferences';
  childEntity: ContentType;
  childId: Scalars['UUID'];
  parentEntity: ContentType;
  parentId: Scalars['UUID'];
};

export type ContentTypeReferencesFilterInput = {
  and?: InputMaybe<Array<ContentTypeReferencesFilterInput>>;
  childEntity?: InputMaybe<ContentTypeFilterInput>;
  childId?: InputMaybe<UuidOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeReferencesFilterInput>>;
  parentEntity?: InputMaybe<ContentTypeFilterInput>;
  parentId?: InputMaybe<UuidOperationFilterInput>;
};

export type ContentTypeSortInput = {
  description?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
  spaceId?: InputMaybe<SortEnumType>;
  sys?: InputMaybe<SysSortInput>;
};

export type CreateContentTypeInput = {
  description: Scalars['String'];
  spaceId: Scalars['UUID'];
  uniqueName: Scalars['String'];
};

export type CreateContentTypePayload = {
  __typename?: 'CreateContentTypePayload';
  description: Scalars['String'];
  id: Scalars['UUID'];
  name: Scalars['String'];
  spaceId: Scalars['UUID'];
};

export type CreateOrganizationInput = {
  organizationName: Scalars['String'];
  userId: Scalars['UUID'];
};

export type CreateOrganizationPayload = {
  __typename?: 'CreateOrganizationPayload';
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type CreateSpaceInput = {
  name: Scalars['String'];
  organizationId: Scalars['UUID'];
};

export type CreateSpacePayload = {
  __typename?: 'CreateSpacePayload';
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type DateTimeOperationFilterInput = {
  eq?: InputMaybe<Scalars['DateTime']>;
  gt?: InputMaybe<Scalars['DateTime']>;
  gte?: InputMaybe<Scalars['DateTime']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['DateTime']>>>;
  lt?: InputMaybe<Scalars['DateTime']>;
  lte?: InputMaybe<Scalars['DateTime']>;
  neq?: InputMaybe<Scalars['DateTime']>;
  ngt?: InputMaybe<Scalars['DateTime']>;
  ngte?: InputMaybe<Scalars['DateTime']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['DateTime']>>>;
  nlt?: InputMaybe<Scalars['DateTime']>;
  nlte?: InputMaybe<Scalars['DateTime']>;
};

export type DeleteOrganizationInput = {
  organizationId: Scalars['UUID'];
  userId: Scalars['UUID'];
};

export type DeleteOrganizationPayload = {
  __typename?: 'DeleteOrganizationPayload';
  boolean?: Maybe<Scalars['Boolean']>;
};

export type DeleteSpaceInput = {
  spaceId: Scalars['UUID'];
};

export type DeleteSpacePayload = {
  __typename?: 'DeleteSpacePayload';
  boolean?: Maybe<Scalars['Boolean']>;
};

export type IntOperationFilterInput = {
  eq?: InputMaybe<Scalars['Int']>;
  gt?: InputMaybe<Scalars['Int']>;
  gte?: InputMaybe<Scalars['Int']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['Int']>>>;
  lt?: InputMaybe<Scalars['Int']>;
  lte?: InputMaybe<Scalars['Int']>;
  neq?: InputMaybe<Scalars['Int']>;
  ngt?: InputMaybe<Scalars['Int']>;
  ngte?: InputMaybe<Scalars['Int']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['Int']>>>;
  nlt?: InputMaybe<Scalars['Int']>;
  nlte?: InputMaybe<Scalars['Int']>;
};

export type ListFilterInputTypeOfBasicFieldDtoFilterInput = {
  all?: InputMaybe<BasicFieldDtoFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<BasicFieldDtoFilterInput>;
  some?: InputMaybe<BasicFieldDtoFilterInput>;
};

export type ListFilterInputTypeOfBasicFieldFilterInput = {
  all?: InputMaybe<BasicFieldFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<BasicFieldFilterInput>;
  some?: InputMaybe<BasicFieldFilterInput>;
};

export type ListFilterInputTypeOfContentTypeNestedChildrenDtoFilterInput = {
  all?: InputMaybe<ContentTypeNestedChildrenDtoFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<ContentTypeNestedChildrenDtoFilterInput>;
  some?: InputMaybe<ContentTypeNestedChildrenDtoFilterInput>;
};

export type ListFilterInputTypeOfContentTypeReferencesFilterInput = {
  all?: InputMaybe<ContentTypeReferencesFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<ContentTypeReferencesFilterInput>;
  some?: InputMaybe<ContentTypeReferencesFilterInput>;
};

export type ListFilterInputTypeOfListItemDtoFilterInput = {
  all?: InputMaybe<ListItemDtoFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<ListItemDtoFilterInput>;
  some?: InputMaybe<ListItemDtoFilterInput>;
};

export type ListFilterInputTypeOfListItemFilterInput = {
  all?: InputMaybe<ListItemFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<ListItemFilterInput>;
  some?: InputMaybe<ListItemFilterInput>;
};

export type ListFilterInputTypeOfSpaceDtoFilterInput = {
  all?: InputMaybe<SpaceDtoFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<SpaceDtoFilterInput>;
  some?: InputMaybe<SpaceDtoFilterInput>;
};

export type ListFilterInputTypeOfUserDtoFilterInput = {
  all?: InputMaybe<UserDtoFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<UserDtoFilterInput>;
  some?: InputMaybe<UserDtoFilterInput>;
};

export type ListItem = {
  __typename?: 'ListItem';
  basicField: BasicField;
  basicFieldId?: Maybe<Scalars['UUID']>;
  id: Scalars['UUID'];
  value: Scalars['String'];
};

export type ListItemDto = {
  __typename?: 'ListItemDto';
  id: Scalars['UUID'];
  value: Scalars['String'];
};

export type ListItemDtoFilterInput = {
  and?: InputMaybe<Array<ListItemDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  or?: InputMaybe<Array<ListItemDtoFilterInput>>;
  value?: InputMaybe<StringOperationFilterInput>;
};

export type ListItemDtoInput = {
  id: Scalars['UUID'];
  value: Scalars['String'];
};

export type ListItemFilterInput = {
  and?: InputMaybe<Array<ListItemFilterInput>>;
  basicField?: InputMaybe<BasicFieldFilterInput>;
  basicFieldId?: InputMaybe<UuidOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  or?: InputMaybe<Array<ListItemFilterInput>>;
  value?: InputMaybe<StringOperationFilterInput>;
};

export type Mutation = {
  __typename?: 'Mutation';
  createContentType: CreateContentTypePayload;
  createOrganization: CreateOrganizationPayload;
  createSpace: CreateSpacePayload;
  deleteOrganization: DeleteOrganizationPayload;
  deleteSpace: DeleteSpacePayload;
  updateContentFields: UpdateContentFieldsPayload;
};


export type MutationCreateContentTypeArgs = {
  input: CreateContentTypeInput;
};


export type MutationCreateOrganizationArgs = {
  input: CreateOrganizationInput;
};


export type MutationCreateSpaceArgs = {
  input: CreateSpaceInput;
};


export type MutationDeleteOrganizationArgs = {
  input: DeleteOrganizationInput;
};


export type MutationDeleteSpaceArgs = {
  input: DeleteSpaceInput;
};


export type MutationUpdateContentFieldsArgs = {
  input: UpdateContentFieldsInput;
};

export type OrganizationDto = {
  __typename?: 'OrganizationDto';
  id: Scalars['UUID'];
  name: Scalars['String'];
  spaces: Array<SpaceDto>;
  users: Array<UserDto>;
};

export type OrganizationDtoFilterInput = {
  and?: InputMaybe<Array<OrganizationDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<OrganizationDtoFilterInput>>;
  spaces?: InputMaybe<ListFilterInputTypeOfSpaceDtoFilterInput>;
  users?: InputMaybe<ListFilterInputTypeOfUserDtoFilterInput>;
};

export type OrganizationDtoSortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type Query = {
  __typename?: 'Query';
  entities: Array<ContentType>;
  entitiesBySpace: Array<ContentTypeDto>;
  entityById: ContentTypeNestedChildrenDto;
  organizationsByUser: Array<OrganizationDto>;
  spacesByOrganization: Array<SpaceDto>;
};


export type QueryEntitiesArgs = {
  order?: InputMaybe<Array<ContentTypeSortInput>>;
  where?: InputMaybe<ContentTypeFilterInput>;
};


export type QueryEntitiesBySpaceArgs = {
  order?: InputMaybe<Array<ContentTypeDtoSortInput>>;
  spaceId: Scalars['UUID'];
  where?: InputMaybe<ContentTypeDtoFilterInput>;
};


export type QueryEntityByIdArgs = {
  id: Scalars['UUID'];
  order?: InputMaybe<Array<ContentTypeNestedChildrenDtoSortInput>>;
  where?: InputMaybe<ContentTypeNestedChildrenDtoFilterInput>;
};


export type QueryOrganizationsByUserArgs = {
  order?: InputMaybe<Array<OrganizationDtoSortInput>>;
  userId: Scalars['UUID'];
  where?: InputMaybe<OrganizationDtoFilterInput>;
};


export type QuerySpacesByOrganizationArgs = {
  order?: InputMaybe<Array<SpaceDtoSortInput>>;
  organizationId: Scalars['UUID'];
  where?: InputMaybe<SpaceDtoFilterInput>;
};

export enum SortEnumType {
  Asc = 'ASC',
  Desc = 'DESC'
}

export type SpaceDto = {
  __typename?: 'SpaceDto';
  id: Scalars['UUID'];
  name: Scalars['String'];
  organization?: Maybe<OrganizationDto>;
};

export type SpaceDtoFilterInput = {
  and?: InputMaybe<Array<SpaceDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<SpaceDtoFilterInput>>;
  organization?: InputMaybe<OrganizationDtoFilterInput>;
};

export type SpaceDtoSortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
  organization?: InputMaybe<OrganizationDtoSortInput>;
};

export type StringOperationFilterInput = {
  and?: InputMaybe<Array<StringOperationFilterInput>>;
  contains?: InputMaybe<Scalars['String']>;
  endsWith?: InputMaybe<Scalars['String']>;
  eq?: InputMaybe<Scalars['String']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['String']>>>;
  ncontains?: InputMaybe<Scalars['String']>;
  nendsWith?: InputMaybe<Scalars['String']>;
  neq?: InputMaybe<Scalars['String']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['String']>>>;
  nstartsWith?: InputMaybe<Scalars['String']>;
  or?: InputMaybe<Array<StringOperationFilterInput>>;
  startsWith?: InputMaybe<Scalars['String']>;
};

export type Sys = {
  __typename?: 'Sys';
  firstPublishedAt: Scalars['DateTime'];
  id: Scalars['UUID'];
  linkType: Scalars['String'];
  publishedAt: Scalars['DateTime'];
  type: Scalars['String'];
};

export type SysFilterInput = {
  and?: InputMaybe<Array<SysFilterInput>>;
  firstPublishedAt?: InputMaybe<DateTimeOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  linkType?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<SysFilterInput>>;
  publishedAt?: InputMaybe<DateTimeOperationFilterInput>;
  type?: InputMaybe<StringOperationFilterInput>;
};

export type SysSortInput = {
  firstPublishedAt?: InputMaybe<SortEnumType>;
  id?: InputMaybe<SortEnumType>;
  linkType?: InputMaybe<SortEnumType>;
  publishedAt?: InputMaybe<SortEnumType>;
  type?: InputMaybe<SortEnumType>;
};

export type UpdateContentFieldsInput = {
  entityId: Scalars['UUID'];
  fields: Array<BasicFieldDtoInput>;
};

export type UpdateContentFieldsPayload = {
  __typename?: 'UpdateContentFieldsPayload';
  boolean?: Maybe<Scalars['Boolean']>;
};

export type UserDto = {
  __typename?: 'UserDto';
  id: Scalars['UUID'];
  userRole: UserRole;
};

export type UserDtoFilterInput = {
  and?: InputMaybe<Array<UserDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  or?: InputMaybe<Array<UserDtoFilterInput>>;
  userRole?: InputMaybe<UserRoleOperationFilterInput>;
};

export enum UserRole {
  Admin = 'ADMIN',
  Dev = 'DEV',
  Readonly = 'READONLY'
}

export type UserRoleOperationFilterInput = {
  eq?: InputMaybe<UserRole>;
  in?: InputMaybe<Array<UserRole>>;
  neq?: InputMaybe<UserRole>;
  nin?: InputMaybe<Array<UserRole>>;
};

export type UuidOperationFilterInput = {
  eq?: InputMaybe<Scalars['UUID']>;
  gt?: InputMaybe<Scalars['UUID']>;
  gte?: InputMaybe<Scalars['UUID']>;
  in?: InputMaybe<Array<InputMaybe<Scalars['UUID']>>>;
  lt?: InputMaybe<Scalars['UUID']>;
  lte?: InputMaybe<Scalars['UUID']>;
  neq?: InputMaybe<Scalars['UUID']>;
  ngt?: InputMaybe<Scalars['UUID']>;
  ngte?: InputMaybe<Scalars['UUID']>;
  nin?: InputMaybe<Array<InputMaybe<Scalars['UUID']>>>;
  nlt?: InputMaybe<Scalars['UUID']>;
  nlte?: InputMaybe<Scalars['UUID']>;
};

export type CreateContentTypeMutationVariables = Exact<{
  input: CreateContentTypeInput;
}>;


export type CreateContentTypeMutation = { __typename?: 'Mutation', createContentType: { __typename?: 'CreateContentTypePayload', id: any, name: string, description: string, spaceId: any } };

export type UpdateContentFieldsMutationVariables = Exact<{
  input: UpdateContentFieldsInput;
}>;


export type UpdateContentFieldsMutation = { __typename?: 'Mutation', updateContentFields: { __typename?: 'UpdateContentFieldsPayload', boolean?: boolean | null } };

export type EntitiesBySpaceQueryVariables = Exact<{
  spaceId: Scalars['UUID'];
}>;


export type EntitiesBySpaceQuery = { __typename?: 'Query', entitiesBySpace: Array<{ __typename?: 'ContentTypeDto', id: any, name: string, description?: string | null }> };

export type EntityChildrenFieldsFragment = { __typename?: 'ContentTypeNestedChildrenDto', id: any, name: string, description?: string | null } & { ' $fragmentName'?: 'EntityChildrenFieldsFragment' };

export type EntityChildrenRecursiveFragment = { __typename?: 'ContentTypeNestedChildrenDto', children: Array<(
    { __typename?: 'ContentTypeNestedChildrenDto', children: Array<(
      { __typename?: 'ContentTypeNestedChildrenDto', children: Array<(
        { __typename?: 'ContentTypeNestedChildrenDto', children: Array<(
          { __typename?: 'ContentTypeNestedChildrenDto', children: Array<(
            { __typename?: 'ContentTypeNestedChildrenDto' }
            & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment } }
          )> }
          & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment } }
        )> }
        & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment } }
      )> }
      & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment } }
    )> }
    & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment } }
  )> } & { ' $fragmentName'?: 'EntityChildrenRecursiveFragment' };

export type EntityByIdQueryVariables = Exact<{
  id: Scalars['UUID'];
}>;


export type EntityByIdQuery = { __typename?: 'Query', entityById: (
    { __typename?: 'ContentTypeNestedChildrenDto', basicFields: Array<{ __typename?: 'BasicFieldDto', id: any, name: string, value?: string | null, type: number, listItems?: Array<{ __typename?: 'ListItemDto', id: any, value: string }> | null }> }
    & { ' $fragmentRefs'?: { 'EntityChildrenFieldsFragment': EntityChildrenFieldsFragment;'EntityChildrenRecursiveFragment': EntityChildrenRecursiveFragment } }
  ) };

export type CreateOrganizationMutationVariables = Exact<{
  input: CreateOrganizationInput;
}>;


export type CreateOrganizationMutation = { __typename?: 'Mutation', createOrganization: { __typename?: 'CreateOrganizationPayload', id: any, name: string } };

export type DeleteOrganizationMutationVariables = Exact<{
  input: DeleteOrganizationInput;
}>;


export type DeleteOrganizationMutation = { __typename?: 'Mutation', deleteOrganization: { __typename?: 'DeleteOrganizationPayload', boolean?: boolean | null } };

export type OrganizationsQueryVariables = Exact<{
  userId: Scalars['UUID'];
}>;


export type OrganizationsQuery = { __typename?: 'Query', organizationsByUser: Array<{ __typename?: 'OrganizationDto', id: any, name: string, spaces: Array<{ __typename?: 'SpaceDto', id: any, name: string }>, users: Array<{ __typename?: 'UserDto', id: any, userRole: UserRole }> }> };

export type DeleteSpaceMutationVariables = Exact<{
  input: DeleteSpaceInput;
}>;


export type DeleteSpaceMutation = { __typename?: 'Mutation', deleteSpace: { __typename?: 'DeleteSpacePayload', boolean?: boolean | null } };

export type SpacesQueryVariables = Exact<{
  organizationId: Scalars['UUID'];
}>;


export type SpacesQuery = { __typename?: 'Query', spacesByOrganization: Array<{ __typename?: 'SpaceDto', id: any, name: string }> };

export type CreateSpaceMutationVariables = Exact<{
  input: CreateSpaceInput;
}>;


export type CreateSpaceMutation = { __typename?: 'Mutation', createSpace: { __typename?: 'CreateSpacePayload', id: any, name: string } };

export const EntityChildrenFieldsFragmentDoc = {"kind":"Document","definitions":[{"kind":"FragmentDefinition","name":{"kind":"Name","value":"EntityChildrenFields"},"typeCondition":{"kind":"NamedType","name":{"kind":"Name","value":"ContentTypeNestedChildrenDto"}},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"description"}}]}}]} as unknown as DocumentNode<EntityChildrenFieldsFragment, unknown>;
export const EntityChildrenRecursiveFragmentDoc = {"kind":"Document","definitions":[{"kind":"FragmentDefinition","name":{"kind":"Name","value":"EntityChildrenRecursive"},"typeCondition":{"kind":"NamedType","name":{"kind":"Name","value":"ContentTypeNestedChildrenDto"}},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}}]}}]}}]}}]}}]}}]}},{"kind":"FragmentDefinition","name":{"kind":"Name","value":"EntityChildrenFields"},"typeCondition":{"kind":"NamedType","name":{"kind":"Name","value":"ContentTypeNestedChildrenDto"}},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"description"}}]}}]} as unknown as DocumentNode<EntityChildrenRecursiveFragment, unknown>;
export const CreateContentTypeDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"CreateContentType"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"CreateContentTypeInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createContentType"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"description"}},{"kind":"Field","name":{"kind":"Name","value":"spaceId"}}]}}]}}]} as unknown as DocumentNode<CreateContentTypeMutation, CreateContentTypeMutationVariables>;
export const UpdateContentFieldsDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"UpdateContentFields"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UpdateContentFieldsInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"updateContentFields"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"boolean"}}]}}]}}]} as unknown as DocumentNode<UpdateContentFieldsMutation, UpdateContentFieldsMutationVariables>;
export const EntitiesBySpaceDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"EntitiesBySpace"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"spaceId"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"entitiesBySpace"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"spaceId"},"value":{"kind":"Variable","name":{"kind":"Name","value":"spaceId"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"description"}}]}}]}}]} as unknown as DocumentNode<EntitiesBySpaceQuery, EntitiesBySpaceQueryVariables>;
export const EntityByIdDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"EntityById"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"id"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"entityById"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"id"},"value":{"kind":"Variable","name":{"kind":"Name","value":"id"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"basicFields"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"value"}},{"kind":"Field","name":{"kind":"Name","value":"type"}},{"kind":"Field","name":{"kind":"Name","value":"listItems"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"value"}}]}}]}},{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenRecursive"}}]}}]}},{"kind":"FragmentDefinition","name":{"kind":"Name","value":"EntityChildrenFields"},"typeCondition":{"kind":"NamedType","name":{"kind":"Name","value":"ContentTypeNestedChildrenDto"}},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"description"}}]}},{"kind":"FragmentDefinition","name":{"kind":"Name","value":"EntityChildrenRecursive"},"typeCondition":{"kind":"NamedType","name":{"kind":"Name","value":"ContentTypeNestedChildrenDto"}},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}},{"kind":"Field","name":{"kind":"Name","value":"children"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"FragmentSpread","name":{"kind":"Name","value":"EntityChildrenFields"}}]}}]}}]}}]}}]}}]}}]} as unknown as DocumentNode<EntityByIdQuery, EntityByIdQueryVariables>;
export const CreateOrganizationDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"CreateOrganization"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"CreateOrganizationInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}}]}}]} as unknown as DocumentNode<CreateOrganizationMutation, CreateOrganizationMutationVariables>;
export const DeleteOrganizationDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"DeleteOrganization"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"DeleteOrganizationInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"deleteOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"boolean"}}]}}]}}]} as unknown as DocumentNode<DeleteOrganizationMutation, DeleteOrganizationMutationVariables>;
export const OrganizationsDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"Organizations"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"userId"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"organizationsByUser"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"userId"},"value":{"kind":"Variable","name":{"kind":"Name","value":"userId"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"spaces"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}},{"kind":"Field","name":{"kind":"Name","value":"users"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"userRole"}}]}}]}}]}}]} as unknown as DocumentNode<OrganizationsQuery, OrganizationsQueryVariables>;
export const DeleteSpaceDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"DeleteSpace"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"DeleteSpaceInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"deleteSpace"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"boolean"}}]}}]}}]} as unknown as DocumentNode<DeleteSpaceMutation, DeleteSpaceMutationVariables>;
export const SpacesDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"Spaces"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"organizationId"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"spacesByOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"organizationId"},"value":{"kind":"Variable","name":{"kind":"Name","value":"organizationId"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}}]}}]} as unknown as DocumentNode<SpacesQuery, SpacesQueryVariables>;
export const CreateSpaceDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"CreateSpace"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"CreateSpaceInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createSpace"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}}]}}]} as unknown as DocumentNode<CreateSpaceMutation, CreateSpaceMutationVariables>;