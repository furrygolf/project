python ../PyModels/wordchar2vector.py --train 0 --vectorize 1 --i ../tmp/known_words.txt --o ../tmp/wordchar2vector.dat --model_dir ../tmp --dims 56
cp ../tmp/wordchar2vector.dat ../data/wordchar2vector.dat
