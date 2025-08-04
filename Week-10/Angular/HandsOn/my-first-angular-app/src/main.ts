import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { App } from './app/app';
// import { Demo1 } from './app/demo1/demo1';

bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
