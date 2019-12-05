import { MemberListComponent } from './member-list/member-list.component';
import { HomeComponent } from './home/home.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { Routes } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
{ path: '', component: HomeComponent},
{
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
        { path: 'members', component: MemberListComponent, canActivate: [AuthGuard]},
        { path: 'messages', component: MessagesComponent},
        { path: 'lists', component: ListsComponent}
    ]
},
{ path: '**', redirectTo: 'home', pathMatch: 'full'}
];
