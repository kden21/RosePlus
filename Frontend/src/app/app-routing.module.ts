import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {IndexPageComponent} from "./pages/index-page/index-page.component";
import {PolicyPageComponent} from "./pages/policy-page/policy-page.component";
import {DeliveryPageComponent} from "./pages/delivery-page/delivery-page.component";
import {AgreePageComponent} from "./pages/agree-page/agree-page.component";
import {AboutPageComponent} from "./pages/about-page/about-page.component";
import {PaymentPageComponent} from "./pages/payment-page/payment-page.component";

const routes: Routes = [
  //{ path: '', pathMatch: 'full', redirectTo: '' },
  { path: '', component: IndexPageComponent, data: { customBreadcrumb: 'Главная'}},
  { path: 'policy', component: PolicyPageComponent, data: { customBreadcrumb: 'Gdf'}},
  { path: 'policy/agree', component: AgreePageComponent, data: { customBreadcrumb: 'Пользовательское соглашение'}},
  { path: 'about', component: AboutPageComponent },
  { path: 'payment', component: PaymentPageComponent },
  { path: 'delivery', component: DeliveryPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {scrollPositionRestoration: "top"})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
