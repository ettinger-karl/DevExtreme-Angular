import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'DevExtremeAngular',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://host.docker.internal:44363',
    redirectUri: baseUrl,
    clientId: 'DevExtremeAngular_App',
    responseType: 'code',
    scope: 'offline_access DevExtremeAngular',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://host.docker.internal:44363',
      rootNamespace: 'DevExtremeAngular',
    },
  },
} as Environment;
