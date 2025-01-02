from django.contrib import admin
from .models import User
# Register your models here.

@admin.register(User)
class UserAdmin(admin.ModelAdmin):
    list_display = ('username', 'email', 'date_joined', 'is_active')
    search_fields = ('username', 'email')
    list_filter = ('is_active',)