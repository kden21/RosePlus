import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NZ_I18N } from 'ng-zorro-antd/i18n';
import { ru_RU } from 'ng-zorro-antd/i18n';
import { registerLocaleData } from '@angular/common';
import ru from '@angular/common/locales/ru';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { IconsProviderModule } from './icons-provider.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import {NzBreadCrumbModule} from "ng-zorro-antd/breadcrumb";
import {NzGridModule} from "ng-zorro-antd/grid";
import {NzButtonModule} from "ng-zorro-antd/button";
import {NzTypographyModule} from "ng-zorro-antd/typography";
import {NzBackTopModule} from "ng-zorro-antd/back-top";
import {NzInputModule} from "ng-zorro-antd/input";
import {WindowService} from "./services/WindowService";
import { HeaderSearchComponent } from './components/header-search/header-search.component';
import { HeaderTopComponent } from './components/header-top/header-top.component';
import { ContentComponent } from './components/content/content.component';
import { FooterContentComponent } from './components/footer-content/footer-content.component';
import { BottomMenuComponent } from './components/bottom-menu/bottom-menu.component';
import {NzBadgeModule} from "ng-zorro-antd/badge";
import {NzCarouselModule} from "ng-zorro-antd/carousel";
import {NzDividerModule} from "ng-zorro-antd/divider";
import { SearchComponent } from './components/search/search.component';
import { HeaderMobileComponent } from './components/header-mobile/header-mobile.component';
import { IndexPageComponent } from './pages/index-page/index-page.component';
import { PolicyPageComponent } from './pages/policy-page/policy-page.component';
import { AgreePageComponent } from './pages/agree-page/agree-page.component';
import { AboutPageComponent } from './pages/about-page/about-page.component';
import { PaymentPageComponent } from './pages/payment-page/payment-page.component';
import { DeliveryPageComponent } from './pages/delivery-page/delivery-page.component';
import {BreadcrumbModule} from "xng-breadcrumb";

registerLocaleData(ru);

@NgModule({
  declarations: [
    AppComponent,
    HeaderSearchComponent,
    HeaderTopComponent,
    ContentComponent,
    FooterContentComponent,
    BottomMenuComponent,
    SearchComponent,
    HeaderMobileComponent,
    IndexPageComponent,
    PolicyPageComponent,
    AgreePageComponent,
    AboutPageComponent,
    PaymentPageComponent,
    DeliveryPageComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    IconsProviderModule,
    NzLayoutModule,
    NzMenuModule,
    NzBreadCrumbModule,
    NzGridModule,
    NzButtonModule,
    NzTypographyModule,
    NzBackTopModule,
    NzInputModule,
    NzBadgeModule,
    NzCarouselModule,
    NzDividerModule,
    BreadcrumbModule
  ],
  providers: [
    { provide: NZ_I18N, useValue: ru_RU },
    WindowService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
