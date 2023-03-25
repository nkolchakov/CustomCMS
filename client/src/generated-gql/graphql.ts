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
  name: Scalars['String'];
  required?: Maybe<Scalars['Boolean']>;
  type: Cms_Type;
  value: Scalars['String'];
};

export type BasicFieldDto = {
  __typename?: 'BasicFieldDto';
  id: Scalars['UUID'];
  name: Scalars['String'];
  required?: Maybe<Scalars['Boolean']>;
  type: Cms_Type;
  value: Scalars['String'];
};

export type BasicFieldDtoFilterInput = {
  and?: InputMaybe<Array<BasicFieldDtoFilterInput>>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<BasicFieldDtoFilterInput>>;
  required?: InputMaybe<BooleanOperationFilterInput>;
  type?: InputMaybe<Cms_TypeOperationFilterInput>;
  value?: InputMaybe<StringOperationFilterInput>;
};

export type BasicFieldFilterInput = {
  and?: InputMaybe<Array<BasicFieldFilterInput>>;
  contentType?: InputMaybe<ContentTypeFilterInput>;
  contentTypeId?: InputMaybe<UuidOperationFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
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
  id: Scalars['UUID'];
  name: Scalars['String'];
  parents: Array<ContentTypeReferences>;
  spaceId: Scalars['UUID'];
  sys?: Maybe<Sys>;
};

export type ContentTypeDto = {
  __typename?: 'ContentTypeDto';
  basicFields: Array<BasicFieldDto>;
  id: Scalars['UUID'];
  name: Scalars['String'];
};

export type ContentTypeDtoFilterInput = {
  and?: InputMaybe<Array<ContentTypeDtoFilterInput>>;
  basicFields?: InputMaybe<ListFilterInputTypeOfBasicFieldDtoFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeDtoFilterInput>>;
};

export type ContentTypeDtoSortInput = {
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
};

export type ContentTypeFilterInput = {
  and?: InputMaybe<Array<ContentTypeFilterInput>>;
  basicFields?: InputMaybe<ListFilterInputTypeOfBasicFieldFilterInput>;
  children?: InputMaybe<ListFilterInputTypeOfContentTypeReferencesFilterInput>;
  id?: InputMaybe<UuidOperationFilterInput>;
  name?: InputMaybe<StringOperationFilterInput>;
  or?: InputMaybe<Array<ContentTypeFilterInput>>;
  parents?: InputMaybe<ListFilterInputTypeOfContentTypeReferencesFilterInput>;
  spaceId?: InputMaybe<UuidOperationFilterInput>;
  sys?: InputMaybe<SysFilterInput>;
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
  id?: InputMaybe<SortEnumType>;
  name?: InputMaybe<SortEnumType>;
  spaceId?: InputMaybe<SortEnumType>;
  sys?: InputMaybe<SysSortInput>;
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
  spaceDto?: Maybe<SpaceDto>;
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

export type ListFilterInputTypeOfContentTypeReferencesFilterInput = {
  all?: InputMaybe<ContentTypeReferencesFilterInput>;
  any?: InputMaybe<Scalars['Boolean']>;
  none?: InputMaybe<ContentTypeReferencesFilterInput>;
  some?: InputMaybe<ContentTypeReferencesFilterInput>;
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

export type Mutation = {
  __typename?: 'Mutation';
  createOrganization: CreateOrganizationPayload;
  createSpace: CreateSpacePayload;
  deleteOrganization: DeleteOrganizationPayload;
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
  entityById: Array<ContentTypeDto>;
  organizationsByUser: Array<OrganizationDto>;
  spacesByOrganization: Array<SpaceDto>;
};


export type QueryEntitiesArgs = {
  order?: InputMaybe<Array<ContentTypeSortInput>>;
  where?: InputMaybe<ContentTypeFilterInput>;
};


export type QueryEntityByIdArgs = {
  id: Scalars['UUID'];
  order?: InputMaybe<Array<ContentTypeDtoSortInput>>;
  where?: InputMaybe<ContentTypeDtoFilterInput>;
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

export type SpacesQueryVariables = Exact<{
  organizationId: Scalars['UUID'];
}>;


export type SpacesQuery = { __typename?: 'Query', spacesByOrganization: Array<{ __typename?: 'SpaceDto', id: any, name: string }> };


export const CreateOrganizationDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"CreateOrganization"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"CreateOrganizationInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"createOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}}]}}]} as unknown as DocumentNode<CreateOrganizationMutation, CreateOrganizationMutationVariables>;
export const DeleteOrganizationDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"mutation","name":{"kind":"Name","value":"DeleteOrganization"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"input"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"DeleteOrganizationInput"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"deleteOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"input"},"value":{"kind":"Variable","name":{"kind":"Name","value":"input"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"boolean"}}]}}]}}]} as unknown as DocumentNode<DeleteOrganizationMutation, DeleteOrganizationMutationVariables>;
export const OrganizationsDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"Organizations"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"userId"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"organizationsByUser"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"userId"},"value":{"kind":"Variable","name":{"kind":"Name","value":"userId"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}},{"kind":"Field","name":{"kind":"Name","value":"spaces"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}},{"kind":"Field","name":{"kind":"Name","value":"users"},"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"userRole"}}]}}]}}]}}]} as unknown as DocumentNode<OrganizationsQuery, OrganizationsQueryVariables>;
export const SpacesDocument = {"kind":"Document","definitions":[{"kind":"OperationDefinition","operation":"query","name":{"kind":"Name","value":"Spaces"},"variableDefinitions":[{"kind":"VariableDefinition","variable":{"kind":"Variable","name":{"kind":"Name","value":"organizationId"}},"type":{"kind":"NonNullType","type":{"kind":"NamedType","name":{"kind":"Name","value":"UUID"}}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"spacesByOrganization"},"arguments":[{"kind":"Argument","name":{"kind":"Name","value":"organizationId"},"value":{"kind":"Variable","name":{"kind":"Name","value":"organizationId"}}}],"selectionSet":{"kind":"SelectionSet","selections":[{"kind":"Field","name":{"kind":"Name","value":"id"}},{"kind":"Field","name":{"kind":"Name","value":"name"}}]}}]}}]} as unknown as DocumentNode<SpacesQuery, SpacesQueryVariables>;