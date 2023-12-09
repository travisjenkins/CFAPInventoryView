#run the setup script to create the DB and the schema in the DB and seed the database with test data
#do this in a loop because the timing for when the SQL instance is ready is indeterminate
for i in {1..50};
do
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P $MSSQL_SA_PASSWORD -d master -i initial_db_create.sql -I
    if [ $? -eq 0 ]
    then
        echo "initial_db_create.sql completed"
        break
    else
        echo "not ready yet..."
        sleep 1
    fi
done
