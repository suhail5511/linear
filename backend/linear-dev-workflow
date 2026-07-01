---
name: linear-dev-workflow
description: >
  Use this skill whenever the user wants to write, edit, fix, or refactor code in a project
  that uses Linear for project management. Triggers when the user mentions a Linear issue,
  task, or ticket, or says things like "implement this feature", "fix this bug", "work on
  this task", "start coding", "develop this", or references src/ folder files. Also trigger
  when the user pastes a Linear task description and wants Claude to act on it. This skill
  ensures Claude always reads architecture.md and developer-workflow.md before touching any
  code, follows the project's established patterns, writes to the correct src/ folder
  locations, and updates change.log after completing work.
---
 
# Linear Developer Workflow Skill
 
This skill governs how Claude approaches any coding task in projects managed via Linear.
It enforces a strict read-before-write discipline and ensures all code changes respect
the project's architecture and developer conventions.
 
---
 
## Step 1 — Read Context Files (MANDATORY, before any code)
 
Before writing a single line of code, Claude MUST read these files in order:
 
1. **`architecture.md`** — Understand the project structure, layer responsibilities,
   module boundaries, naming conventions, and folder layout. Never place files in the
   wrong layer or deviate from the described patterns.
2. **`developer-workflow.md`** — Understand how development tasks are structured,
   branch/commit conventions, coding standards, and any project-specific rules.
If either file is missing, stop and ask the user to provide it before proceeding.
 
```
view architecture.md        → understand structure & patterns
view developer-workflow.md  → understand coding standards & workflow rules
```
 
---
 
## Step 2 — Understand the Task
 
After reading the context files, clearly restate:
 
- **What** needs to be built or changed
- **Which src/ files** will be created or modified
- **Which layer** it belongs to (based on architecture.md)
If the task came from a Linear issue, use the issue title and description as the
source of truth for scope. Do not add features beyond what is described.
 
---
 
## Step 3 — Write the Code
 
### Project Stack
- **Frontend**: Vue.js (components in `src/`)
- **Backend**: .NET Core (C# — services, controllers, models)
### Rules
- Follow folder structure exactly as defined in `architecture.md`
- Follow naming conventions, patterns, and code style from `developer-workflow.md`
- Keep Vue components single-responsibility
- Keep .NET Core services focused — no business logic in controllers
- Do not introduce new dependencies without flagging them to the user first
- Write code that matches the existing patterns already in the codebase (don't invent new patterns)
---
 
## Step 4 — Update change.log
 
After writing or modifying code, append an entry to `change.log` in this format:
 
```
## [YYYY-MM-DD] — <Short title of change>
 
### Changed
- <file or module>: <what was done and why>
 
### Added (if applicable)
- <new file or feature>: <brief description>
```
 
Use today's date. Keep entries concise but informative enough for a teammate to understand
what changed without reading the diff.
 
---
 
## Step 5 — Summary to User
 
After completing the work, give the user a brief summary:
 
- Files created or modified
- What the code does
- Any assumptions made
- Anything that needs follow-up (e.g. environment variables, migrations, missing context)
---
 
## Quick Reference Checklist
 
```
[ ] Read architecture.md
[ ] Read developer-workflow.md
[ ] Identified correct src/ location for changes
[ ] Code written following established patterns
[ ] change.log updated
[ ] Summary provided to user
```
