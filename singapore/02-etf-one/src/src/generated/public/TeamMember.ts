// @generated
// This file is automatically generated by Kanel. Do not modify manually.

import type { ColumnType, Selectable, Insertable, Updateable } from 'kysely';

/** Identifier type for public.team_member */
export type TeamMemberId = string & { __brand: 'TeamMemberId' };

/** Represents the table public.team_member */
export default interface TeamMemberTable {
  id: ColumnType<TeamMemberId, TeamMemberId, TeamMemberId>;

  team_id: ColumnType<string, string, string>;

  user_id: ColumnType<string, string, string>;

  name: ColumnType<string, string, string>;

  role: ColumnType<string, string, string>;

  address: ColumnType<string, string, string>;

  created_at: ColumnType<Date, Date | string | undefined, Date | string>;
}

export type TeamMember = Selectable<TeamMemberTable>;

export type NewTeamMember = Insertable<TeamMemberTable>;

export type TeamMemberUpdate = Updateable<TeamMemberTable>;