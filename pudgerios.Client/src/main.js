import { createApp } from 'vue'
import { createRouter, createWebHistory }  from 'vue-router'
import App from './App.vue'

import Index from './views/Index.vue'
import Bookform from './views/Bookform.vue'
import NotFound from './views/NotFound.vue'
import Userform from './views/Userform.vue'
import User from './views/User.vue'

const routes = [
	{ path: '/', component: Index },
	{ path: '/book', component: Bookform },
	{ path: '/user/login', component: Userform },
	{ path: '/user', component: User },
	{ path: '/:catchAll', component: NotFound }
];

const router = createRouter({
	history: createWebHistory(),
	routes,
});

createApp(App).use(router).mount('#app');
