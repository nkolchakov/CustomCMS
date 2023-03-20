/* tslint:disable */
/* eslint-disable */
// @generated
// This file was automatically generated and should not be edited.

// ====================================================
// GraphQL query operation: Organizations
// ====================================================

export interface Organizations_organizationsByUser_spaces {
  __typename: "SpaceDto";
  id: any;
  name: string;
}

export interface Organizations_organizationsByUser {
  __typename: "OrganizationDto";
  id: any;
  name: string;
  spaces: Organizations_organizationsByUser_spaces[];
}

export interface Organizations {
  organizationsByUser: Organizations_organizationsByUser[];
}

export interface OrganizationsVariables {
  userId: any;
}
