apt-get -y install screen bzip2 tar build-essential g++ libmysql++-dev wget unzip libbz2-dev libgmp3-dev git
cd /home
wget http://downloads.sourceforge.net/project/boost/boost/1.54.0/boost_1_54_0.tar.bz2
tar xjf boost_1_54_0.tar.bz2
cd boost_1_54_0
./bootstrap.sh --with-libraries=filesystem,program_options,system,regex,thread,date_time --libdir=/usr/lib/
./bjam
./bjam install
cd /home
git clone https://github.com/b1glord/OHSystem.git
cd /home/ohsystem/ghost++/bncsutil/src/bncsutil
make
make install
cd /home/ohsystem/ghost++/StormLib/stormlib
make
make install
cd /home/ohsystem/ghost++/ghost
make
cp ghost++ ../
cd /home/ohsystem/ghost++/update_stats
make
cp stats ../
