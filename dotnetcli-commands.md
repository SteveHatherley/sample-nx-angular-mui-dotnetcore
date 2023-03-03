# Running entity framework cli and other dotnet tools
nx-dotnet uses an intermediate build path, which causes dotnet cli to have problems if you use `dotnet ef ...`. You must specify the `--project` and `--msbuildprojectextensionspath` params to run EF cli tooling.

This is a gap in nx-dotnet for not providing a more sophisticated wrapper for dotnet tools

```bash
dotnet ef dbcontext scaffold "Host=localhost:5432;Database=postgres;Username=postgres;Password=postgres" Npgsql.EntityFrameworkCore.PostgreSQL --msbuildprojectextensionspath=/home/steve/workspaces/coding-challenges/sample-nx-angular-mui-dotnetcore/dist/intermediates/apps/api/obj --project=/home/steve/workspaces/coding-challenges/sample-nx-angular-mui-dotnetcore/apps/api/Init.Api.csproj
```