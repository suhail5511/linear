# Developer Workflow

## Branch Strategy

| Branch | Purpose |
|---|---|
| `main` | Production-ready code only |
| `develop` | Integration branch for completed features |
| `feature/xxx` | Individual feature or bug fix work |

## Branch Naming Convention
feature/MOH-5-navigation-tab-not-working

## Starting a New Task

1. Read the Linear issue
2. Read `architecture.md` before writing any code
3. Create feature branch from `develop`
4. Write code following layered architecture
5. Self review your code
6. Update `CHANGELOG.md`
7. Raise PR targeting `develop`
8. Merge after self review
9. Deploy manually

## Commit Message Convention
[MOH-XX] Short description of what was done

## Important Rules

- Never push directly to `main` or `develop`
- Always use DTOs — never expose models directly
- Always update `CHANGELOG.md` after completing a task
- Always run migrations after model changes
- Never hardcode secrets
