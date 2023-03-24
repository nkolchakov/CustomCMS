
import type { CodegenConfig } from '@graphql-codegen/cli';

const config: CodegenConfig = {
  overwrite: true,
  schema: "https://localhost:7010/graphql",
  documents: "./src/components/**/*.{ts,tsx}",
  generates: {
    "./src/generated-gql/": {
      preset: "client",
      plugins: []
    }
  }
};

export default config;
