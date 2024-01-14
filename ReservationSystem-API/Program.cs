var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddDbContext<ReservationSystem_API.Data.AppDbContext>();
// Add services to the container.
builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// TODO ���� ����ȯ�濡�� �׽�Ʈ �ϱ� ���� �ӽ������� �����
builder.WebHost.ConfigureKestrel((context, serverOptions) =>
{
    //serverOptions.ListenAnyIP(5175);
    //serverOptions.ListenAnyIP(7110);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder
                    .AllowAnyHeader()
                    .SetIsOriginAllowed((host) => true)
                    .AllowCredentials()
                    .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
